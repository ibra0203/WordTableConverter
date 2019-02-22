namespace WordTableConverter
{
    partial class FormLoadFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Button_loadSourceFile = new System.Windows.Forms.Button();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Label_SourceFileName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_error1 = new System.Windows.Forms.Label();
            this.txtBox_SourceCols = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_LoadTargetFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_TargetFileName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_error2 = new System.Windows.Forms.Label();
            this.txtBox_DestCols = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Button_Next = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.loadingGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_loadSourceFile
            // 
            this.Button_loadSourceFile.Location = new System.Drawing.Point(203, 55);
            this.Button_loadSourceFile.Name = "Button_loadSourceFile";
            this.Button_loadSourceFile.Size = new System.Drawing.Size(99, 28);
            this.Button_loadSourceFile.TabIndex = 0;
            this.Button_loadSourceFile.Text = "Load";
            this.Button_loadSourceFile.UseVisualStyleBackColor = true;
            this.Button_loadSourceFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.Filter = "Word Documents (*.doc) (*.docx)|*.doc*";
            this.loadFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Load Source Word File(Filled Tables)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_SourceFileName
            // 
            this.Label_SourceFileName.AutoSize = true;
            this.Label_SourceFileName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label_SourceFileName.Location = new System.Drawing.Point(80, 97);
            this.Label_SourceFileName.Name = "Label_SourceFileName";
            this.Label_SourceFileName.Size = new System.Drawing.Size(75, 17);
            this.Label_SourceFileName.TabIndex = 2;
            this.Label_SourceFileName.Text = "FileName1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Label_error1);
            this.panel1.Controls.Add(this.txtBox_SourceCols);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Label_SourceFileName);
            this.panel1.Controls.Add(this.Button_loadSourceFile);
            this.panel1.Location = new System.Drawing.Point(78, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 180);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Label_error1
            // 
            this.Label_error1.AutoSize = true;
            this.Label_error1.ForeColor = System.Drawing.Color.Red;
            this.Label_error1.Location = new System.Drawing.Point(256, 120);
            this.Label_error1.Name = "Label_error1";
            this.Label_error1.Size = new System.Drawing.Size(128, 17);
            this.Label_error1.TabIndex = 6;
            this.Label_error1.Text = "Error: Invalid Value";
            // 
            // txtBox_SourceCols
            // 
            this.txtBox_SourceCols.Location = new System.Drawing.Point(271, 140);
            this.txtBox_SourceCols.Name = "txtBox_SourceCols";
            this.txtBox_SourceCols.Size = new System.Drawing.Size(100, 22);
            this.txtBox_SourceCols.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "columns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Match rows with";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Button_LoadTargetFile
            // 
            this.Button_LoadTargetFile.Location = new System.Drawing.Point(203, 73);
            this.Button_LoadTargetFile.Name = "Button_LoadTargetFile";
            this.Button_LoadTargetFile.Size = new System.Drawing.Size(99, 28);
            this.Button_LoadTargetFile.TabIndex = 3;
            this.Button_LoadTargetFile.Text = "Load";
            this.Button_LoadTargetFile.UseVisualStyleBackColor = true;
            this.Button_LoadTargetFile.Click += new System.EventHandler(this.Button_LoadTargetFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(137, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Load Target Word File (Empty Tables)";
            // 
            // Label_TargetFileName
            // 
            this.Label_TargetFileName.AutoSize = true;
            this.Label_TargetFileName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Label_TargetFileName.Location = new System.Drawing.Point(80, 110);
            this.Label_TargetFileName.Name = "Label_TargetFileName";
            this.Label_TargetFileName.Size = new System.Drawing.Size(75, 17);
            this.Label_TargetFileName.TabIndex = 5;
            this.Label_TargetFileName.Text = "FileName1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Label_error2);
            this.panel2.Controls.Add(this.txtBox_DestCols);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Label_TargetFileName);
            this.panel2.Controls.Add(this.Button_LoadTargetFile);
            this.panel2.Location = new System.Drawing.Point(78, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 183);
            this.panel2.TabIndex = 4;
            // 
            // Label_error2
            // 
            this.Label_error2.AutoSize = true;
            this.Label_error2.ForeColor = System.Drawing.Color.Red;
            this.Label_error2.Location = new System.Drawing.Point(255, 123);
            this.Label_error2.Name = "Label_error2";
            this.Label_error2.Size = new System.Drawing.Size(128, 17);
            this.Label_error2.TabIndex = 7;
            this.Label_error2.Text = "Error: Invalid Value";
            // 
            // txtBox_DestCols
            // 
            this.txtBox_DestCols.Location = new System.Drawing.Point(259, 143);
            this.txtBox_DestCols.Name = "txtBox_DestCols";
            this.txtBox_DestCols.Size = new System.Drawing.Size(100, 22);
            this.txtBox_DestCols.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "columns";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Match rows with";
            // 
            // Button_Next
            // 
            this.Button_Next.Location = new System.Drawing.Point(584, 447);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(108, 29);
            this.Button_Next.TabIndex = 5;
            this.Button_Next.Text = "Next";
            this.Button_Next.UseVisualStyleBackColor = true;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // loadingGif
            // 
            this.loadingGif.BackColor = System.Drawing.Color.Transparent;
            this.loadingGif.Image = global::WordTableConverter.Properties.Resources.load;
            this.loadingGif.Location = new System.Drawing.Point(506, 439);
            this.loadingGif.Name = "loadingGif";
            this.loadingGif.Size = new System.Drawing.Size(60, 56);
            this.loadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingGif.TabIndex = 7;
            this.loadingGif.TabStop = false;
            this.loadingGif.Visible = false;
            this.loadingGif.VisibleChanged += new System.EventHandler(this.loadingGif_VisibleChanged);
            // 
            // FormLoadFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.loadingGif);
            this.Controls.Add(this.Button_Next);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormLoadFiles";
            this.Text = "Word Table Importer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoadFiles_FormClosing);
            this.Load += new System.EventHandler(this.FormLoadFiles_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_loadSourceFile;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_SourceFileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label_TargetFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_LoadTargetFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_DestCols;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_SourceCols;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_error2;
        private System.Windows.Forms.Label Label_error1;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox loadingGif;
    }
}

