namespace ECG_Analyzer
{
    partial class DataAnalysisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.saveDataBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boudCBox = new System.Windows.Forms.ComboBox();
            this.portCBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataTBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dayCountTBox = new System.Windows.Forms.TextBox();
            this.patientIdTBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.portErrorLabel = new System.Windows.Forms.Label();
            this.boudeErrorLabel = new System.Windows.Forms.Label();
            this.patientIdErrorLabel = new System.Windows.Forms.Label();
            this.dayCountTBoxErrorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IsoElectricLineTexBox = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Q_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerPanel.SuspendLayout();
            this.leftMenuPanel.SuspendLayout();
            this.masterLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.panel6);
            this.headerPanel.Size = new System.Drawing.Size(1016, 40);
            this.headerPanel.Controls.SetChildIndex(this.panel6, 0);
            this.headerPanel.Controls.SetChildIndex(this.backBtn, 0);
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.Controls.Add(this.label3);
            this.leftMenuPanel.Controls.Add(this.portCBox);
            this.leftMenuPanel.Controls.Add(this.label4);
            this.leftMenuPanel.Controls.Add(this.flowLayoutPanel1);
            this.leftMenuPanel.Controls.Add(this.boudCBox);
            this.leftMenuPanel.Controls.Add(this.label2);
            this.leftMenuPanel.Controls.Add(this.dataTBox);
            this.leftMenuPanel.Controls.Add(this.patientIdTBox);
            this.leftMenuPanel.Controls.Add(this.label7);
            this.leftMenuPanel.Controls.Add(this.label6);
            this.leftMenuPanel.Controls.Add(this.label5);
            this.leftMenuPanel.Controls.Add(this.dayCountTBox);
            this.leftMenuPanel.Controls.Add(this.dayCountTBoxErrorLabel);
            this.leftMenuPanel.Controls.Add(this.patientIdErrorLabel);
            this.leftMenuPanel.Controls.Add(this.boudeErrorLabel);
            this.leftMenuPanel.Controls.Add(this.portErrorLabel);
            this.leftMenuPanel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.leftMenuPanel.Size = new System.Drawing.Size(200, 575);
            // 
            // masterLayoutPanel
            // 
            this.masterLayoutPanel.Controls.Add(this.panel2);
            this.masterLayoutPanel.Controls.Add(this.dataGridView);
            this.masterLayoutPanel.ForeColor = System.Drawing.Color.Black;
            this.masterLayoutPanel.Size = new System.Drawing.Size(816, 575);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(5, 5);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(182, 35);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Red;
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(5, 46);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(182, 35);
            this.stopBtn.TabIndex = 0;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // saveDataBtn
            // 
            this.saveDataBtn.BackColor = System.Drawing.Color.Green;
            this.saveDataBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveDataBtn.FlatAppearance.BorderSize = 0;
            this.saveDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDataBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDataBtn.Location = new System.Drawing.Point(5, 87);
            this.saveDataBtn.Name = "saveDataBtn";
            this.saveDataBtn.Size = new System.Drawing.Size(182, 35);
            this.saveDataBtn.TabIndex = 0;
            this.saveDataBtn.Text = "Save Data";
            this.saveDataBtn.UseVisualStyleBackColor = false;
            this.saveDataBtn.Click += new System.EventHandler(this.saveDataBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Time";
            // 
            // boudCBox
            // 
            this.boudCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boudCBox.FormattingEnabled = true;
            this.boudCBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.boudCBox.Location = new System.Drawing.Point(9, 198);
            this.boudCBox.Name = "boudCBox";
            this.boudCBox.Size = new System.Drawing.Size(183, 22);
            this.boudCBox.TabIndex = 2;
            this.boudCBox.SelectedIndexChanged += new System.EventHandler(this.boudCBox_SelectedIndexChanged);
            // 
            // portCBox
            // 
            this.portCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portCBox.FormattingEnabled = true;
            this.portCBox.Location = new System.Drawing.Point(9, 154);
            this.portCBox.Name = "portCBox";
            this.portCBox.Size = new System.Drawing.Size(183, 22);
            this.portCBox.TabIndex = 2;
            this.portCBox.SelectedIndexChanged += new System.EventHandler(this.portCBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Boud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port";
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(509, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(507, 548);
            this.panel6.TabIndex = 4;
            // 
            // dataTBox
            // 
            this.dataTBox.Location = new System.Drawing.Point(10, 333);
            this.dataTBox.Margin = new System.Windows.Forms.Padding(5);
            this.dataTBox.Multiline = true;
            this.dataTBox.Name = "dataTBox";
            this.dataTBox.Size = new System.Drawing.Size(182, 221);
            this.dataTBox.TabIndex = 5;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PatientId,
            this.TestDate,
            this.Day_Count,
            this.DayCycle,
            this.P_Data,
            this.Q_Data,
            this.R_Data,
            this.S_Data,
            this.T_Data});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(816, 575);
            this.dataGridView.TabIndex = 2;
            // 
            // dayCountTBox
            // 
            this.dayCountTBox.Location = new System.Drawing.Point(9, 284);
            this.dayCountTBox.Name = "dayCountTBox";
            this.dayCountTBox.Size = new System.Drawing.Size(183, 22);
            this.dayCountTBox.TabIndex = 8;
            this.dayCountTBox.TextChanged += new System.EventHandler(this.dayCountTBox_TextChanged);
            // 
            // patientIdTBox
            // 
            this.patientIdTBox.Location = new System.Drawing.Point(9, 242);
            this.patientIdTBox.Name = "patientIdTBox";
            this.patientIdTBox.Size = new System.Drawing.Size(183, 22);
            this.patientIdTBox.TabIndex = 8;
            this.patientIdTBox.TextChanged += new System.EventHandler(this.patientIdTBox_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.startBtn);
            this.flowLayoutPanel1.Controls.Add(this.stopBtn);
            this.flowLayoutPanel1.Controls.Add(this.saveDataBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(190, 132);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Test Count";
            // 
            // portErrorLabel
            // 
            this.portErrorLabel.AutoSize = true;
            this.portErrorLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portErrorLabel.ForeColor = System.Drawing.Color.Yellow;
            this.portErrorLabel.Location = new System.Drawing.Point(176, 135);
            this.portErrorLabel.Name = "portErrorLabel";
            this.portErrorLabel.Size = new System.Drawing.Size(21, 24);
            this.portErrorLabel.TabIndex = 1;
            this.portErrorLabel.Text = "*";
            this.portErrorLabel.Visible = false;
            // 
            // boudeErrorLabel
            // 
            this.boudeErrorLabel.AutoSize = true;
            this.boudeErrorLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boudeErrorLabel.ForeColor = System.Drawing.Color.Yellow;
            this.boudeErrorLabel.Location = new System.Drawing.Point(176, 179);
            this.boudeErrorLabel.Name = "boudeErrorLabel";
            this.boudeErrorLabel.Size = new System.Drawing.Size(21, 24);
            this.boudeErrorLabel.TabIndex = 1;
            this.boudeErrorLabel.Text = "*";
            this.boudeErrorLabel.Visible = false;
            // 
            // patientIdErrorLabel
            // 
            this.patientIdErrorLabel.AutoSize = true;
            this.patientIdErrorLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdErrorLabel.ForeColor = System.Drawing.Color.Yellow;
            this.patientIdErrorLabel.Location = new System.Drawing.Point(176, 223);
            this.patientIdErrorLabel.Name = "patientIdErrorLabel";
            this.patientIdErrorLabel.Size = new System.Drawing.Size(21, 24);
            this.patientIdErrorLabel.TabIndex = 1;
            this.patientIdErrorLabel.Text = "*";
            this.patientIdErrorLabel.Visible = false;
            // 
            // dayCountTBoxErrorLabel
            // 
            this.dayCountTBoxErrorLabel.AutoSize = true;
            this.dayCountTBoxErrorLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayCountTBoxErrorLabel.ForeColor = System.Drawing.Color.Yellow;
            this.dayCountTBoxErrorLabel.Location = new System.Drawing.Point(176, 265);
            this.dayCountTBoxErrorLabel.Name = "dayCountTBoxErrorLabel";
            this.dayCountTBoxErrorLabel.Size = new System.Drawing.Size(21, 24);
            this.dayCountTBoxErrorLabel.TabIndex = 1;
            this.dayCountTBoxErrorLabel.Text = "*";
            this.dayCountTBoxErrorLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(147, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Data";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IsoElectricLineTexBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 550);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 25);
            this.panel2.TabIndex = 3;
            // 
            // IsoElectricLineTexBox
            // 
            this.IsoElectricLineTexBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IsoElectricLineTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsoElectricLineTexBox.Location = new System.Drawing.Point(0, 0);
            this.IsoElectricLineTexBox.Name = "IsoElectricLineTexBox";
            this.IsoElectricLineTexBox.Size = new System.Drawing.Size(816, 23);
            this.IsoElectricLineTexBox.TabIndex = 0;
            this.IsoElectricLineTexBox.TextChanged += new System.EventHandler(this.IsoElectricLineTexBox_TextChanged);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // PatientId
            // 
            this.PatientId.HeaderText = "Patient ID";
            this.PatientId.Name = "PatientId";
            this.PatientId.ReadOnly = true;
            // 
            // TestDate
            // 
            this.TestDate.HeaderText = "Test Date";
            this.TestDate.Name = "TestDate";
            this.TestDate.ReadOnly = true;
            // 
            // Day_Count
            // 
            this.Day_Count.HeaderText = "Day Count";
            this.Day_Count.Name = "Day_Count";
            this.Day_Count.ReadOnly = true;
            // 
            // DayCycle
            // 
            this.DayCycle.HeaderText = "Cycle";
            this.DayCycle.Name = "DayCycle";
            this.DayCycle.ReadOnly = true;
            // 
            // P_Data
            // 
            this.P_Data.HeaderText = "P";
            this.P_Data.Name = "P_Data";
            this.P_Data.ReadOnly = true;
            // 
            // Q_Data
            // 
            this.Q_Data.HeaderText = "Q";
            this.Q_Data.Name = "Q_Data";
            this.Q_Data.ReadOnly = true;
            // 
            // R_Data
            // 
            this.R_Data.HeaderText = "R";
            this.R_Data.Name = "R_Data";
            this.R_Data.ReadOnly = true;
            // 
            // S_Data
            // 
            this.S_Data.HeaderText = "S";
            this.S_Data.Name = "S_Data";
            this.S_Data.ReadOnly = true;
            // 
            // T_Data
            // 
            this.T_Data.HeaderText = "T";
            this.T_Data.Name = "T_Data";
            this.T_Data.ReadOnly = true;
            // 
            // DataAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 615);
            this.Name = "DataAnalysisForm";
            this.Text = "DataAnalysis";
            this.Load += new System.EventHandler(this.DataAnalysis_Load);
            this.headerPanel.ResumeLayout(false);
            this.leftMenuPanel.ResumeLayout(false);
            this.leftMenuPanel.PerformLayout();
            this.masterLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveDataBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.ComboBox boudCBox;
        private System.Windows.Forms.ComboBox portCBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox dataTBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox dayCountTBox;
        private System.Windows.Forms.TextBox patientIdTBox;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dayCountTBoxErrorLabel;
        private System.Windows.Forms.Label patientIdErrorLabel;
        private System.Windows.Forms.Label boudeErrorLabel;
        private System.Windows.Forms.Label portErrorLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox IsoElectricLineTexBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Q_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_Data;
    }
}