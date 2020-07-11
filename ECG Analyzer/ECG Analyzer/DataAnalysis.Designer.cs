namespace ECG_Analyzer
{
    partial class DataAnalysis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.saveDataBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalTimeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.boudCBox = new System.Windows.Forms.ComboBox();
            this.portCBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.dataTBox = new System.Windows.Forms.TextBox();
            this.headerPanel.SuspendLayout();
            this.leftMenuPanel.SuspendLayout();
            this.masterLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.panel6);
            this.headerPanel.Size = new System.Drawing.Size(1016, 40);
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.Controls.Add(this.dataTBox);
            this.leftMenuPanel.Controls.Add(this.label5);
            this.leftMenuPanel.Controls.Add(this.progressBar);
            this.leftMenuPanel.Controls.Add(this.panel2);
            this.leftMenuPanel.Controls.Add(this.panel1);
            this.leftMenuPanel.Controls.Add(this.saveDataBtn);
            this.leftMenuPanel.Controls.Add(this.stopBtn);
            this.leftMenuPanel.Controls.Add(this.startBtn);
            this.leftMenuPanel.Size = new System.Drawing.Size(153, 575);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(153, 594);
            this.footerPanel.Size = new System.Drawing.Size(863, 21);
            // 
            // masterLayoutPanel
            // 
            this.masterLayoutPanel.Controls.Add(this.panel3);
            this.masterLayoutPanel.Controls.Add(this.dataGridView1);
            this.masterLayoutPanel.ForeColor = System.Drawing.Color.Black;
            this.masterLayoutPanel.Location = new System.Drawing.Point(153, 40);
            this.masterLayoutPanel.Size = new System.Drawing.Size(863, 554);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(108)))), ((int)(((byte)(50)))));
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(3, 32);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(145, 35);
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
            this.stopBtn.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(3, 73);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(145, 35);
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
            this.saveDataBtn.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDataBtn.Location = new System.Drawing.Point(3, 114);
            this.saveDataBtn.Name = "saveDataBtn";
            this.saveDataBtn.Size = new System.Drawing.Size(145, 35);
            this.saveDataBtn.TabIndex = 0;
            this.saveDataBtn.Text = "Save Data";
            this.saveDataBtn.UseVisualStyleBackColor = false;
            this.saveDataBtn.Click += new System.EventHandler(this.saveDataBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.totalTimeTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 36);
            this.panel1.TabIndex = 1;
            // 
            // totalTimeTextBox
            // 
            this.totalTimeTextBox.Location = new System.Drawing.Point(92, 6);
            this.totalTimeTextBox.Name = "totalTimeTextBox";
            this.totalTimeTextBox.Size = new System.Drawing.Size(48, 23);
            this.totalTimeTextBox.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.boudCBox);
            this.panel2.Controls.Add(this.portCBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 67);
            this.panel2.TabIndex = 2;
            // 
            // boudCBox
            // 
            this.boudCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boudCBox.FormattingEnabled = true;
            this.boudCBox.Items.AddRange(new object[] {
            "123456",
            "123456",
            "123456",
            "123456",
            "123456"});
            this.boudCBox.Location = new System.Drawing.Point(48, 32);
            this.boudCBox.Name = "boudCBox";
            this.boudCBox.Size = new System.Drawing.Size(89, 23);
            this.boudCBox.TabIndex = 2;
            // 
            // portCBox
            // 
            this.portCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portCBox.FormattingEnabled = true;
            this.portCBox.Items.AddRange(new object[] {
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.portCBox.Location = new System.Drawing.Point(48, 5);
            this.portCBox.Name = "portCBox";
            this.portCBox.Size = new System.Drawing.Size(89, 23);
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
            this.label2.Size = new System.Drawing.Size(36, 15);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cycle,
            this.PData,
            this.QData,
            this.RData,
            this.SData,
            this.TData});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(863, 554);
            this.dataGridView1.TabIndex = 0;
            // 
            // Cycle
            // 
            this.Cycle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Cycle.DefaultCellStyle = dataGridViewCellStyle6;
            this.Cycle.HeaderText = "Cycle";
            this.Cycle.Name = "Cycle";
            this.Cycle.Width = 58;
            // 
            // PData
            // 
            this.PData.HeaderText = "P";
            this.PData.Name = "PData";
            // 
            // QData
            // 
            this.QData.HeaderText = "Q";
            this.QData.Name = "QData";
            // 
            // RData
            // 
            this.RData.HeaderText = "R";
            this.RData.Name = "RData";
            // 
            // SData
            // 
            this.SData.HeaderText = "S";
            this.SData.Name = "SData";
            // 
            // TData
            // 
            this.TData.HeaderText = "T";
            this.TData.Name = "TData";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 345);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 209);
            this.panel3.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Silver;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(863, 209);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(4, 198);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(143, 23);
            this.progressBar.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Progress Bar";
            // 
            // dataTBox
            // 
            this.dataTBox.Location = new System.Drawing.Point(4, 345);
            this.dataTBox.Multiline = true;
            this.dataTBox.Name = "dataTBox";
            this.dataTBox.Size = new System.Drawing.Size(143, 193);
            this.dataTBox.TabIndex = 5;
            // 
            // DataAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 615);
            this.Name = "DataAnalysis";
            this.Text = "DataAnalysis";
            this.headerPanel.ResumeLayout(false);
            this.leftMenuPanel.ResumeLayout(false);
            this.leftMenuPanel.PerformLayout();
            this.masterLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox totalTimeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveDataBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boudCBox;
        private System.Windows.Forms.ComboBox portCBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PData;
        private System.Windows.Forms.DataGridViewTextBoxColumn QData;
        private System.Windows.Forms.DataGridViewTextBoxColumn RData;
        private System.Windows.Forms.DataGridViewTextBoxColumn SData;
        private System.Windows.Forms.DataGridViewTextBoxColumn TData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox dataTBox;
    }
}