using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordTableConverter
{
    public partial class FormWindow : Form
    {
        public FormWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormWindow_Load(object sender, EventArgs e)
        {
            WindowManager.SetMainForm(this);
            WindowManager.SwitchForm(FORMS.LOADFILE);

        }
        public bool SwitchToForm(Form newForm)
        {

            FormPanel.Controls.Clear();
            //newForm.Show();
            for (int i=newForm.Controls.Count-1; i>=0; i--)
            {
                newForm.Controls[i].Parent = FormPanel;
  
            }
            FormPanel.Dock = DockStyle.Fill;
            return true;
               
        }

        private void FormWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            WordManager.Close();
            Application.Exit();
        }
    }
}
