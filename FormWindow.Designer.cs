namespace WordTableConverter
{
    partial class FormWindow
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.AutoSize = true;
            this.FormPanel.Location = new System.Drawing.Point(0, 0);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(780, 493);
            this.FormPanel.TabIndex = 0;
            // 
            // FormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.FormPanel);
            this.Name = "FormWindow";
            this.Text = "Word Table Importer - ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWindow_FormClosed);
            this.Load += new System.EventHandler(this.FormWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel FormPanel;
    }
}