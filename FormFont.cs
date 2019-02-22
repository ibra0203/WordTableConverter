using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordTableConverter
{
    public partial class FormFont : Form
    {
        public FormFont()
        {
            InitializeComponent();
            textboxFont.Text = DocumentManager.cellFont.Name;
            textboxSize.Text = DocumentManager.cellFont.Size.ToString();
            DocumentManager.EProgressChanged += new DocumentManager.DataChanged(this.updateSaveProgress);
        }

        private void FormFont_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_saveMsg.Text = "Saving File..";
            button1.Enabled = false;
            saveBar.Visible = true;
            DocumentManager.cellFont.Name = textboxFont.Text;
            if(Helpers.isFloat(textboxSize.Text))
            DocumentManager.cellFont.Size = float.Parse(textboxSize.Text);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                object fileName = saveFileDialog1.FileName;
                DocumentManager.PrepareSaveFile();
                Task.Factory.StartNew(new Action(() => saveFile(ref fileName)));
                
            }
        }

        private void FormFont_FormClosed(object sender, FormClosedEventArgs e)
        {
            WordManager.Close();
            Application.Exit();
        }

        delegate void deleg(ref object filename);
        delegate void vdeleg();
        private void updateSaveProgress()
        {
            if (button1.InvokeRequired)
            {
                vdeleg d = new vdeleg(updateSaveProgress);
                WindowManager.GetMainForm().BeginInvoke(d);
            }
            else
            {
                int amount = DocumentManager.ProgressAmount;
                if (amount > 0 && amount < 100)
                    saveBar.Value = DocumentManager.ProgressAmount;

            }
        }

        private void saveFile(ref object filename)
        {
            
            if (button1.InvokeRequired)
            {

                DocumentManager.SaveFile(ref filename);
               
                deleg d = new deleg(saveFile);
                WindowManager.GetMainForm().BeginInvoke(d, new object[] {filename });
                return;

            }
            else
            {
                label_saveMsg.Text = "Saved File!";
                saveBar.Visible = false;
                return;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
