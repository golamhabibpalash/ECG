namespace ECG_Analyzer
{
    partial class Settings
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.databaseTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataSourceTBox = new System.Windows.Forms.TextBox();
            this.usernameTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwrodTBox = new System.Windows.Forms.TextBox();
            this.intigratedSecurityCBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataSourceErrorLabel = new System.Windows.Forms.Label();
            this.databaseErrorLabel = new System.Windows.Forms.Label();
            this.usernameErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.leftMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Size = new System.Drawing.Size(800, 40);
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.Controls.Add(this.intigratedSecurityCBox);
            this.leftMenuPanel.Controls.Add(this.saveBtn);
            this.leftMenuPanel.Controls.Add(this.passwrodTBox);
            this.leftMenuPanel.Controls.Add(this.databaseTBox);
            this.leftMenuPanel.Controls.Add(this.label2);
            this.leftMenuPanel.Controls.Add(this.label1);
            this.leftMenuPanel.Controls.Add(this.label5);
            this.leftMenuPanel.Controls.Add(this.label3);
            this.leftMenuPanel.Controls.Add(this.usernameTBox);
            this.leftMenuPanel.Controls.Add(this.label4);
            this.leftMenuPanel.Controls.Add(this.dataSourceTBox);
            this.leftMenuPanel.Controls.Add(this.dataSourceErrorLabel);
            this.leftMenuPanel.Controls.Add(this.databaseErrorLabel);
            this.leftMenuPanel.Controls.Add(this.usernameErrorLabel);
            this.leftMenuPanel.Controls.Add(this.passwordErrorLabel);
            this.leftMenuPanel.Size = new System.Drawing.Size(215, 410);
            // 
            // masterLayoutPanel
            // 
            this.masterLayoutPanel.Location = new System.Drawing.Point(215, 40);
            this.masterLayoutPanel.Size = new System.Drawing.Size(585, 389);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(215, 429);
            this.footerPanel.Size = new System.Drawing.Size(585, 21);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(108)))), ((int)(((byte)(50)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(26, 310);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(178, 25);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "&SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // databaseTBox
            // 
            this.databaseTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.databaseTBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseTBox.Location = new System.Drawing.Point(25, 179);
            this.databaseTBox.MaximumSize = new System.Drawing.Size(180, 20);
            this.databaseTBox.Name = "databaseTBox";
            this.databaseTBox.Size = new System.Drawing.Size(178, 17);
            this.databaseTBox.TabIndex = 1;
            this.databaseTBox.TextChanged += new System.EventHandler(this.databaseTBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Database";
            // 
            // dataSourceTBox
            // 
            this.dataSourceTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSourceTBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSourceTBox.Location = new System.Drawing.Point(25, 138);
            this.dataSourceTBox.Name = "dataSourceTBox";
            this.dataSourceTBox.Size = new System.Drawing.Size(178, 17);
            this.dataSourceTBox.TabIndex = 0;
            this.dataSourceTBox.TextChanged += new System.EventHandler(this.dataSourceTBox_TextChanged);
            // 
            // usernameTBox
            // 
            this.usernameTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTBox.Location = new System.Drawing.Point(25, 220);
            this.usernameTBox.Name = "usernameTBox";
            this.usernameTBox.Size = new System.Drawing.Size(178, 17);
            this.usernameTBox.TabIndex = 2;
            this.usernameTBox.TextChanged += new System.EventHandler(this.usernameTBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // passwrodTBox
            // 
            this.passwrodTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwrodTBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrodTBox.Location = new System.Drawing.Point(25, 261);
            this.passwrodTBox.MaximumSize = new System.Drawing.Size(180, 20);
            this.passwrodTBox.Name = "passwrodTBox";
            this.passwrodTBox.PasswordChar = '*';
            this.passwrodTBox.Size = new System.Drawing.Size(178, 17);
            this.passwrodTBox.TabIndex = 3;
            this.passwrodTBox.UseSystemPasswordChar = true;
            this.passwrodTBox.TextChanged += new System.EventHandler(this.passwrodTBox_TextChanged);
            // 
            // intigratedSecurityCBox
            // 
            this.intigratedSecurityCBox.AutoSize = true;
            this.intigratedSecurityCBox.Location = new System.Drawing.Point(26, 285);
            this.intigratedSecurityCBox.Name = "intigratedSecurityCBox";
            this.intigratedSecurityCBox.Size = new System.Drawing.Size(116, 19);
            this.intigratedSecurityCBox.TabIndex = 4;
            this.intigratedSecurityCBox.Text = "Intigrated Security";
            this.intigratedSecurityCBox.UseVisualStyleBackColor = true;
            this.intigratedSecurityCBox.CheckedChanged += new System.EventHandler(this.intigratedSecurityCBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(60, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Settings";
            // 
            // dataSourceErrorLabel
            // 
            this.dataSourceErrorLabel.AutoSize = true;
            this.dataSourceErrorLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSourceErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(108)))), ((int)(((byte)(50)))));
            this.dataSourceErrorLabel.Location = new System.Drawing.Point(185, 117);
            this.dataSourceErrorLabel.Name = "dataSourceErrorLabel";
            this.dataSourceErrorLabel.Size = new System.Drawing.Size(18, 19);
            this.dataSourceErrorLabel.TabIndex = 3;
            this.dataSourceErrorLabel.Text = "*";
            this.dataSourceErrorLabel.Visible = false;
            // 
            // databaseErrorLabel
            // 
            this.databaseErrorLabel.AutoSize = true;
            this.databaseErrorLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(108)))), ((int)(((byte)(50)))));
            this.databaseErrorLabel.Location = new System.Drawing.Point(186, 158);
            this.databaseErrorLabel.Name = "databaseErrorLabel";
            this.databaseErrorLabel.Size = new System.Drawing.Size(18, 19);
            this.databaseErrorLabel.TabIndex = 3;
            this.databaseErrorLabel.Text = "*";
            this.databaseErrorLabel.Visible = false;
            // 
            // usernameErrorLabel
            // 
            this.usernameErrorLabel.AutoSize = true;
            this.usernameErrorLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(108)))), ((int)(((byte)(50)))));
            this.usernameErrorLabel.Location = new System.Drawing.Point(185, 199);
            this.usernameErrorLabel.Name = "usernameErrorLabel";
            this.usernameErrorLabel.Size = new System.Drawing.Size(18, 19);
            this.usernameErrorLabel.TabIndex = 3;
            this.usernameErrorLabel.Text = "*";
            this.usernameErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(108)))), ((int)(((byte)(50)))));
            this.passwordErrorLabel.Location = new System.Drawing.Point(185, 239);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(18, 19);
            this.passwordErrorLabel.TabIndex = 3;
            this.passwordErrorLabel.Text = "*";
            this.passwordErrorLabel.Visible = false;
            // 
            // Settings
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Settings";
            this.Text = "Setting";
            this.leftMenuPanel.ResumeLayout(false);
            this.leftMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox passwrodTBox;
        private System.Windows.Forms.TextBox databaseTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dataSourceTBox;
        private System.Windows.Forms.CheckBox intigratedSecurityCBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label usernameErrorLabel;
        private System.Windows.Forms.Label databaseErrorLabel;
        private System.Windows.Forms.Label dataSourceErrorLabel;
    }
}