namespace ECG_Analyzer
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.roleBtn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.doctorBtn = new System.Windows.Forms.Button();
            this.dataAnalysisBtn = new System.Windows.Forms.Button();
            this.patientsBtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminstratorPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.leftMenuPanel.SuspendLayout();
            this.masterLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Size = new System.Drawing.Size(1040, 40);
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.Controls.Add(this.panel3);
            this.leftMenuPanel.Controls.Add(this.panel2);
            this.leftMenuPanel.Size = new System.Drawing.Size(184, 452);
            this.leftMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftMenuPanel_Paint);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(184, 471);
            this.footerPanel.Size = new System.Drawing.Size(856, 21);
            // 
            // masterLayoutPanel
            // 
            this.masterLayoutPanel.Controls.Add(this.tableLayoutPanel1);
            this.masterLayoutPanel.Controls.Add(this.panel1);
            this.masterLayoutPanel.Location = new System.Drawing.Point(184, 40);
            this.masterLayoutPanel.Size = new System.Drawing.Size(856, 431);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.roleBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.settingBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.doctorBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataAnalysisBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.patientsBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.userBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::ECG_Analyzer.Properties.Resources.statistics;
            this.button8.Location = new System.Drawing.Point(645, 205);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(208, 197);
            this.button8.TabIndex = 7;
            this.button8.Text = "Statistics";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // roleBtn
            // 
            this.roleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleBtn.FlatAppearance.BorderSize = 2;
            this.roleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roleBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleBtn.ForeColor = System.Drawing.Color.White;
            this.roleBtn.Image = global::ECG_Analyzer.Properties.Resources.roleIcon_men;
            this.roleBtn.Location = new System.Drawing.Point(431, 205);
            this.roleBtn.Name = "roleBtn";
            this.roleBtn.Size = new System.Drawing.Size(208, 197);
            this.roleBtn.TabIndex = 6;
            this.roleBtn.Text = "Role";
            this.roleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.roleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roleBtn.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::ECG_Analyzer.Properties.Resources.test_red;
            this.button6.Location = new System.Drawing.Point(217, 205);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(208, 197);
            this.button6.TabIndex = 5;
            this.button6.Text = "Test";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // settingBtn
            // 
            this.settingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingBtn.FlatAppearance.BorderSize = 2;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBtn.ForeColor = System.Drawing.Color.White;
            this.settingBtn.Image = global::ECG_Analyzer.Properties.Resources.settings_128;
            this.settingBtn.Location = new System.Drawing.Point(3, 205);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(208, 197);
            this.settingBtn.TabIndex = 4;
            this.settingBtn.Text = "Settings";
            this.settingBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.settingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // doctorBtn
            // 
            this.doctorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doctorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorBtn.FlatAppearance.BorderSize = 2;
            this.doctorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorBtn.ForeColor = System.Drawing.Color.White;
            this.doctorBtn.Image = global::ECG_Analyzer.Properties.Resources.doctor_male_96;
            this.doctorBtn.Location = new System.Drawing.Point(645, 3);
            this.doctorBtn.Name = "doctorBtn";
            this.doctorBtn.Size = new System.Drawing.Size(208, 196);
            this.doctorBtn.TabIndex = 3;
            this.doctorBtn.Text = "Doctor";
            this.doctorBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.doctorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.doctorBtn.UseVisualStyleBackColor = true;
            this.doctorBtn.Click += new System.EventHandler(this.doctorBtn_Click);
            // 
            // dataAnalysisBtn
            // 
            this.dataAnalysisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataAnalysisBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataAnalysisBtn.FlatAppearance.BorderSize = 2;
            this.dataAnalysisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataAnalysisBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAnalysisBtn.ForeColor = System.Drawing.Color.White;
            this.dataAnalysisBtn.Image = global::ECG_Analyzer.Properties.Resources.dataAnalysis_128;
            this.dataAnalysisBtn.Location = new System.Drawing.Point(431, 3);
            this.dataAnalysisBtn.Name = "dataAnalysisBtn";
            this.dataAnalysisBtn.Size = new System.Drawing.Size(208, 196);
            this.dataAnalysisBtn.TabIndex = 2;
            this.dataAnalysisBtn.Text = "Data Analysis";
            this.dataAnalysisBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dataAnalysisBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dataAnalysisBtn.UseVisualStyleBackColor = true;
            this.dataAnalysisBtn.Click += new System.EventHandler(this.dataAnalysisBtn_Click);
            // 
            // patientsBtn
            // 
            this.patientsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientsBtn.FlatAppearance.BorderSize = 2;
            this.patientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientsBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsBtn.ForeColor = System.Drawing.Color.White;
            this.patientsBtn.Image = global::ECG_Analyzer.Properties.Resources.patient_80;
            this.patientsBtn.Location = new System.Drawing.Point(217, 3);
            this.patientsBtn.Name = "patientsBtn";
            this.patientsBtn.Size = new System.Drawing.Size(208, 196);
            this.patientsBtn.TabIndex = 1;
            this.patientsBtn.Text = "Patients";
            this.patientsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.patientsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.patientsBtn.UseVisualStyleBackColor = true;
            this.patientsBtn.Click += new System.EventHandler(this.patientsBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBtn.FlatAppearance.BorderSize = 2;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.White;
            this.userBtn.Image = global::ECG_Analyzer.Properties.Resources.user_80;
            this.userBtn.Location = new System.Drawing.Point(3, 3);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(208, 196);
            this.userBtn.TabIndex = 0;
            this.userBtn.Text = "Users";
            this.userBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 26);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 26);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminstratorPanel);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 426);
            this.panel3.TabIndex = 0;
            // 
            // adminstratorPanel
            // 
            this.adminstratorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adminstratorPanel.Location = new System.Drawing.Point(3, 6);
            this.adminstratorPanel.Name = "adminstratorPanel";
            this.adminstratorPanel.Size = new System.Drawing.Size(175, 118);
            this.adminstratorPanel.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 35);
            this.button4.TabIndex = 0;
            this.button4.Text = "User Logs";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "Login";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "Billing";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ECG_Analyzer.Properties.Resources.dashboard;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dashboard";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 492);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.leftMenuPanel.ResumeLayout(false);
            this.masterLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button patientsBtn;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button roleBtn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Button doctorBtn;
        private System.Windows.Forms.Button dataAnalysisBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel adminstratorPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}