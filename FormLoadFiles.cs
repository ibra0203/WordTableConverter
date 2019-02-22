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
using Word = Microsoft.Office.Interop.Word;

namespace WordTableConverter
{
    public partial class FormLoadFiles : Form
    {
        bool loadedSource = false, loadedTarget = false;

        public FormLoadFiles()
        {
            InitializeComponent();
            Label_SourceFileName.Text = "";
            Label_TargetFileName.Text = "";
            Label_error1.Visible = false;
            Label_error2.Visible = false;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {

               bool valid = loadFile(ref DocumentManager.SourceDocument, Label_SourceFileName);

                if (valid)
                {
                    loadedSource = true;
                }
                else
                    loadedSource = false;

            }
        }

        bool loadFile(ref Word.Document doc, Label fnameLabel)
        {
            bool success = WordManager.Load(loadFileDialog.FileName, ref doc);
            if (!success)
            {
                return false;
            }
            else
            {
                fnameLabel.Text = loadFileDialog.FileName;
            }

            return true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLoadFiles_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_LoadTargetFile_Click(object sender, EventArgs e)
        {
            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {

               bool valid = loadFile(ref DocumentManager.TargetDocument, Label_TargetFileName);

                if (valid)
                    loadedTarget = true;
                else
                    loadedTarget = false;

            }
        }

        private void FormLoadFiles_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void FormLoadFiles_Load_1(object sender, EventArgs e)
        {
            
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            bool doneDest = true, doneSrc= true;

            String srcCol = txtBox_SourceCols.Text;
            String destCol = txtBox_DestCols.Text;

            int _src=0, _dest=0;

            if (Helpers.isInt(srcCol))
            {
                _src = int.Parse(srcCol);
                if (_src < 1)
                    doneSrc = false;

            }
            else doneSrc = false;

            if (Helpers.isInt(destCol))
            {
                _dest = int.Parse(destCol);
                if (_dest < 1)
                    doneDest = false;

            }
            else doneDest = false;

            if(doneDest && doneSrc)
            {
                if (loadedSource && loadedTarget)
                {


                    loadingGif.Visible = true;
                    Button_Next.Enabled = false;
                    DocumentManager.SetColumnsNumber(_src, _dest);

                    Task t = new Task(() => setData());
                    t.Start();
                   // loadingGif.Visible = false;
                   // WindowManager.SwitchForm(FORMS.COLUMNSETTINGS);


                }
            } 
            else
            {
                bool errorVisible;
                if (!doneDest)
                {
                    errorVisible = true;
                }
                else errorVisible = false;
                Label_error2.Visible = errorVisible;

                if (!doneSrc)
                {
                    errorVisible = true;
                }
                else errorVisible = false;

                Label_error1.Visible = errorVisible;
            }

        }

        private void AutoFill_btn_Click(object sender, EventArgs e)
        {

            string t = "C:\\Downloads\\WRITING FORM.docx";
            string s = "C:\\Users\\Mody\\Documents\\Industrial.docx";
            WordManager.Load(t, ref DocumentManager.TargetDocument);
            WordManager.Load(s, ref DocumentManager.SourceDocument);

            Label_SourceFileName.Text = s;
            Label_TargetFileName.Text = t;
            txtBox_SourceCols.Text = "4";
            txtBox_DestCols.Text = "6";
            loadedSource = true;
            loadedTarget = true;

        
        }

        private void loadingpanel_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       

        private void loadingGif_VisibleChanged(object sender, EventArgs e)
        {
            if (loadingGif.Visible)
            {
               
                
               
            }
        }
        delegate void deleg();
        void setData()
        {
            

            if (loadingGif.InvokeRequired)
            {
                DocumentManager.CopyDataFromSource();
                deleg d = new deleg(setData);
                WindowManager.GetMainForm().BeginInvoke(d);
                return;
                
            }
            else
            {
                WindowManager.SwitchForm(FORMS.COLUMNSETTINGS);
                return;
            }

        }
        
       
    }
}
