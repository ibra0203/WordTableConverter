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
    public partial class FormSettings : Form
    {
        List<ComboBox> comboBoxes;
        List<Label> labels;
        FormFont formFont;
        public FormSettings()
        {
            InitializeComponent();
            init();
        }

        private void FormSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void init()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            comboBoxes = new List<ComboBox>();
            labels = new List<Label>();
            List<String> range = new List<string>();
            for(int i=0; i<DocumentManager.srcCols; i++)
            {
                range.Add((i + 1).ToString());
            }
            range.Add("None");

            TableLayoutRowStyleCollection styles = tableFrom.RowStyles;
            for (int i=0; i<DocumentManager.destCols; i++)
            {
                Label label = new Label();
                label.Text = (i + 1).ToString();
                label.Size = new Size(20, 20);
                labels.Add(label);

                ComboBox box = new ComboBox();
                box.Items.AddRange(range.ToArray());
                comboBoxes.Add(box);

                box.Anchor = AnchorStyles.None;
                label.Anchor = AnchorStyles.None;

                tableFrom.Controls.Add(box, 0, i);
                tableFrom.Controls.Add(label, 2, i);

                if(styles.Count <= i+1)
                {
                    RowStyle newStyle = new RowStyle();
                    newStyle.SizeType = SizeType.Absolute;
                    newStyle.Height = 30;
                    styles.Add(newStyle);
                }
                else
                {
                    styles[i].SizeType = SizeType.Absolute;
                    styles[i].Height = 30;
                }

            }

            
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            for (int i=0; i< comboBoxes.Count; i++)
            {
                ComboBox c = comboBoxes[i];
                bool isInt = Helpers.isInt(c.Text);
                int res = 0;
                if(isInt)
                {
                    res = int.Parse(c.Text);
                }

                DocumentManager.FillingInstructions.Add(res);
            }

            WindowManager.SwitchForm(FORMS.FONTSETTINGS);
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
