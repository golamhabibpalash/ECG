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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.leftMenuPanel.SuspendLayout();
            this.masterLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.panel6);
            this.headerPanel.Size = new System.Drawing.Size(1016, 40);
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.Controls.Add(this.label5);
            this.leftMenuPanel.Controls.Add(this.progressBar1);
            this.leftMenuPanel.Controls.Add(this.panel2);
            this.leftMenuPanel.Controls.Add(this.panel1);
            this.leftMenuPanel.Controls.Add(this.button3);
            this.leftMenuPanel.Controls.Add(this.button2);
            this.leftMenuPanel.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(108)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 36);
            this.panel1.TabIndex = 1;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 23);
            this.textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 67);
            this.panel2.TabIndex = 2;
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.comboBox1.Location = new System.Drawing.Point(48, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "123456",
            "123456",
            "123456",
            "123456",
            "123456"});
            this.comboBox2.Location = new System.Drawing.Point(48, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(89, 23);
            this.comboBox2.TabIndex = 2;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 345);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 209);
            this.panel3.TabIndex = 1;
            // 
            // Cycle
            // 
            this.Cycle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Cycle.DefaultCellStyle = dataGridViewCellStyle2;
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 198);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(143, 23);
            this.progressBar1.TabIndex = 3;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
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
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}