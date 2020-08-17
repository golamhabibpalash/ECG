namespace ECG_Analyzer
{
    partial class MasterLayout2
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
            this.backBtn = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.backBtn);
            this.headerPanel.Size = new System.Drawing.Size(800, 40);
            this.headerPanel.Controls.SetChildIndex(this.backBtn, 0);
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.Size = new System.Drawing.Size(200, 410);
            // 
            // masterLayoutPanel
            // 
            this.masterLayoutPanel.Location = new System.Drawing.Point(200, 40);
            this.masterLayoutPanel.Size = new System.Drawing.Size(600, 410);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::ECG_Analyzer.Properties.Resources.back_96;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(40, 40);
            this.backBtn.TabIndex = 1;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // MasterLayout2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MasterLayout2";
            this.Text = "MasterLayout2";
            this.Load += new System.EventHandler(this.MasterLayout2_Load);
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button backBtn;
    }
}