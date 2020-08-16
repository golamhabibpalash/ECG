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
            this.portBoudPanel = new System.Windows.Forms.Panel();
            this.boudCBox = new System.Windows.Forms.ComboBox();
            this.portCBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataTBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.hRateTBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.patientIdTBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dayCountTBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.leftMenuPanel.SuspendLayout();
            this.masterLayoutPanel.SuspendLayout();
            this.portBoudPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.leftMenuPanel.Controls.Add(this.panel2);
            this.leftMenuPanel.Controls.Add(this.panel1);
            this.leftMenuPanel.Controls.Add(this.flowLayoutPanel1);
            this.leftMenuPanel.Controls.Add(this.hRateTBox);
            this.leftMenuPanel.Controls.Add(this.dataTBox);
            this.leftMenuPanel.Controls.Add(this.label6);
            this.leftMenuPanel.Controls.Add(this.portBoudPanel);
            this.leftMenuPanel.Size = new System.Drawing.Size(200, 575);
            // 
            // masterLayoutPanel
            // 
            this.masterLayoutPanel.Controls.Add(this.dataGridView);
            this.masterLayoutPanel.ForeColor = System.Drawing.Color.Black;
            this.masterLayoutPanel.Size = new System.Drawing.Size(816, 554);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(200, 594);
            this.footerPanel.Size = new System.Drawing.Size(816, 21);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(8, 8);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(186, 35);
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
            this.stopBtn.Location = new System.Drawing.Point(8, 49);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(186, 35);
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
            this.saveDataBtn.Location = new System.Drawing.Point(8, 90);
            this.saveDataBtn.Name = "saveDataBtn";
            this.saveDataBtn.Size = new System.Drawing.Size(186, 35);
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
            // portBoudPanel
            // 
            this.portBoudPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.portBoudPanel.Controls.Add(this.boudCBox);
            this.portBoudPanel.Controls.Add(this.portCBox);
            this.portBoudPanel.Controls.Add(this.label4);
            this.portBoudPanel.Controls.Add(this.label3);
            this.portBoudPanel.Controls.Add(this.label2);
            this.portBoudPanel.Location = new System.Drawing.Point(3, 235);
            this.portBoudPanel.Name = "portBoudPanel";
            this.portBoudPanel.Size = new System.Drawing.Size(189, 67);
            this.portBoudPanel.TabIndex = 2;
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
            this.boudCBox.Location = new System.Drawing.Point(48, 32);
            this.boudCBox.Name = "boudCBox";
            this.boudCBox.Size = new System.Drawing.Size(138, 22);
            this.boudCBox.TabIndex = 2;
            // 
            // portCBox
            // 
            this.portCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portCBox.FormattingEnabled = true;
            this.portCBox.Location = new System.Drawing.Point(48, 5);
            this.portCBox.Name = "portCBox";
            this.portCBox.Size = new System.Drawing.Size(138, 22);
            this.portCBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Boud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(509, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(507, 548);
            this.panel6.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Patient ID";
            // 
            // dataTBox
            // 
            this.dataTBox.Location = new System.Drawing.Point(8, 308);
            this.dataTBox.Multiline = true;
            this.dataTBox.Name = "dataTBox";
            this.dataTBox.Size = new System.Drawing.Size(184, 246);
            this.dataTBox.TabIndex = 5;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(816, 554);
            this.dataGridView.TabIndex = 2;
            // 
            // hRateTBox
            // 
            this.hRateTBox.Location = new System.Drawing.Point(96, 206);
            this.hRateTBox.Name = "hRateTBox";
            this.hRateTBox.Size = new System.Drawing.Size(96, 22);
            this.hRateTBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Heart Rate";
            // 
            // patientIdTBox
            // 
            this.patientIdTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientIdTBox.Location = new System.Drawing.Point(98, 32);
            this.patientIdTBox.Name = "patientIdTBox";
            this.patientIdTBox.Size = new System.Drawing.Size(89, 22);
            this.patientIdTBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Test Count";
            // 
            // dayCountTBox
            // 
            this.dayCountTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayCountTBox.Location = new System.Drawing.Point(98, 3);
            this.dayCountTBox.Name = "dayCountTBox";
            this.dayCountTBox.Size = new System.Drawing.Size(89, 22);
            this.dayCountTBox.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.startBtn);
            this.flowLayoutPanel1.Controls.Add(this.stopBtn);
            this.flowLayoutPanel1.Controls.Add(this.saveDataBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 132);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dayCountTBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.patientIdTBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(190, 59);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(0, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(200, 69);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(43)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 554);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 21);
            this.panel2.TabIndex = 11;
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
            this.portBoudPanel.ResumeLayout(false);
            this.portBoudPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveDataBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Panel portBoudPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boudCBox;
        private System.Windows.Forms.ComboBox portCBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dataTBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox hRateTBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox patientIdTBox;
        private System.Windows.Forms.TextBox dayCountTBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
    }
}