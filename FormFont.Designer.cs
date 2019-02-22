namespace WordTableConverter
{
    partial class FormFont
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textboxSize = new System.Windows.Forms.TextBox();
            this.textboxFont = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_saveMsg = new System.Windows.Forms.Label();
            this.saveBar = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveBar);
            this.panel1.Controls.Add(this.label_saveMsg);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textboxSize);
            this.panel1.Controls.Add(this.textboxFont);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(114, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 465);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(399, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxSize
            // 
            this.textboxSize.Location = new System.Drawing.Point(232, 191);
            this.textboxSize.Name = "textboxSize";
            this.textboxSize.Size = new System.Drawing.Size(100, 22);
            this.textboxSize.TabIndex = 4;
            // 
            // textboxFont
            // 
            this.textboxFont.Location = new System.Drawing.Point(232, 130);
            this.textboxFont.Name = "textboxFont";
            this.textboxFont.Size = new System.Drawing.Size(100, 22);
            this.textboxFont.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Font";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font Settings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_saveMsg
            // 
            this.label_saveMsg.AutoSize = true;
            this.label_saveMsg.ForeColor = System.Drawing.Color.Blue;
            this.label_saveMsg.Location = new System.Drawing.Point(419, 381);
            this.label_saveMsg.Name = "label_saveMsg";
            this.label_saveMsg.Size = new System.Drawing.Size(0, 17);
            this.label_saveMsg.TabIndex = 1;
            this.label_saveMsg.Click += new System.EventHandler(this.label4_Click);
            // 
            // saveBar
            // 
            this.saveBar.Location = new System.Drawing.Point(143, 419);
            this.saveBar.Name = "saveBar";
            this.saveBar.Size = new System.Drawing.Size(250, 23);
            this.saveBar.TabIndex = 9;
            this.saveBar.Visible = false;
            // 
            // FormFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panel1);
            this.Name = "FormFont";
            this.Text = "Word Table Importer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFont_FormClosed);
            this.Load += new System.EventHandler(this.FormFont_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textboxSize;
        private System.Windows.Forms.TextBox textboxFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_saveMsg;
        private System.Windows.Forms.ProgressBar saveBar;
    }
}