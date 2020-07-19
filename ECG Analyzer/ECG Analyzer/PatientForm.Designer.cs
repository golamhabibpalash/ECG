namespace ECG_Analyzer
{
    partial class PatientForm
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
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.Size = new System.Drawing.Size(150, 410);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(150, 429);
            this.footerPanel.Size = new System.Drawing.Size(650, 21);
            // 
            // masterLayoutPanel
            // 
            this.masterLayoutPanel.Location = new System.Drawing.Point(150, 40);
            this.masterLayoutPanel.Size = new System.Drawing.Size(650, 389);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}