namespace ECG_Analyzer
{
    partial class Login
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
            this.enterBtn = new System.Windows.Forms.Button();
            this.passwordTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userNameTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.leftMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Size = new System.Drawing.Size(1041, 40);
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.Controls.Add(this.enterBtn);
            this.leftMenuPanel.Controls.Add(this.passwordTBox);
            this.leftMenuPanel.Controls.Add(this.label3);
            this.leftMenuPanel.Controls.Add(this.label4);
            this.leftMenuPanel.Controls.Add(this.userNameTBox);
            this.leftMenuPanel.Size = new System.Drawing.Size(213, 601);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(213, 631);
            this.footerPanel.Size = new System.Drawing.Size(828, 10);
            // 
            // masterLayoutPanel
            // 
            this.masterLayoutPanel.Location = new System.Drawing.Point(213, 40);
            this.masterLayoutPanel.Size = new System.Drawing.Size(828, 591);
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(108)))), ((int)(((byte)(50)))));
            this.enterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterBtn.FlatAppearance.BorderSize = 0;
            this.enterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBtn.ForeColor = System.Drawing.Color.Black;
            this.enterBtn.Location = new System.Drawing.Point(24, 237);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(178, 25);
            this.enterBtn.TabIndex = 2;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // passwordTBox
            // 
            this.passwordTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTBox.Location = new System.Drawing.Point(24, 202);
            this.passwordTBox.MaximumSize = new System.Drawing.Size(180, 20);
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.Size = new System.Drawing.Size(178, 17);
            this.passwordTBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // userNameTBox
            // 
            this.userNameTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTBox.Location = new System.Drawing.Point(24, 159);
            this.userNameTBox.Name = "userNameTBox";
            this.userNameTBox.Size = new System.Drawing.Size(178, 17);
            this.userNameTBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // Login
            // 
            this.AcceptButton = this.enterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 641);
            this.ControlBox = false;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.leftMenuPanel.ResumeLayout(false);
            this.leftMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.TextBox passwordTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userNameTBox;
        private System.Windows.Forms.Label label3;
    }
}