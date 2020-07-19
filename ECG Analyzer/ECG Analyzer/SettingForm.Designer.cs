namespace ECG_Analyzer
{
    partial class SettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.personalizationBtn = new System.Windows.Forms.Button();
            this.DatabaseSettingBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.leftMenuPanel.SuspendLayout();
            this.masterLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.Controls.Add(this.button6);
            this.leftMenuPanel.Controls.Add(this.button5);
            this.leftMenuPanel.Controls.Add(this.button4);
            this.leftMenuPanel.Controls.Add(this.button3);
            this.leftMenuPanel.Controls.Add(this.DatabaseSettingBtn);
            this.leftMenuPanel.Controls.Add(this.personalizationBtn);
            this.leftMenuPanel.Size = new System.Drawing.Size(150, 410);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(150, 429);
            this.footerPanel.Size = new System.Drawing.Size(650, 21);
            // 
            // masterLayoutPanel
            // 
            this.masterLayoutPanel.Controls.Add(this.label1);
            this.masterLayoutPanel.Location = new System.Drawing.Point(150, 40);
            this.masterLayoutPanel.Size = new System.Drawing.Size(650, 389);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setting";
            // 
            // personalizationBtn
            // 
            this.personalizationBtn.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalizationBtn.ForeColor = System.Drawing.Color.Black;
            this.personalizationBtn.Location = new System.Drawing.Point(3, 24);
            this.personalizationBtn.Name = "personalizationBtn";
            this.personalizationBtn.Size = new System.Drawing.Size(144, 30);
            this.personalizationBtn.TabIndex = 0;
            this.personalizationBtn.Text = "Personalization";
            this.personalizationBtn.UseVisualStyleBackColor = true;
            // 
            // DatabaseSettingBtn
            // 
            this.DatabaseSettingBtn.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseSettingBtn.ForeColor = System.Drawing.Color.Black;
            this.DatabaseSettingBtn.Location = new System.Drawing.Point(3, 60);
            this.DatabaseSettingBtn.Name = "DatabaseSettingBtn";
            this.DatabaseSettingBtn.Size = new System.Drawing.Size(144, 30);
            this.DatabaseSettingBtn.TabIndex = 0;
            this.DatabaseSettingBtn.Text = "Database Setting";
            this.DatabaseSettingBtn.UseVisualStyleBackColor = true;
            this.DatabaseSettingBtn.Click += new System.EventHandler(this.DatabaseSettingBtn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(3, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 30);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(3, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 30);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(3, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 30);
            this.button5.TabIndex = 0;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(3, 204);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 30);
            this.button6.TabIndex = 0;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.leftMenuPanel.ResumeLayout(false);
            this.masterLayoutPanel.ResumeLayout(false);
            this.masterLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button DatabaseSettingBtn;
        private System.Windows.Forms.Button personalizationBtn;
    }
}