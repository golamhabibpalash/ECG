namespace ECG_Analyzer
{
    partial class MasterLayoutForm
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ccmsLabel = new System.Windows.Forms.Label();
            this.leftMenuPanel = new System.Windows.Forms.Panel();
            this.masterLayoutPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.headerPanel.Controls.Add(this.tableLayoutPanel1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerPanel.ForeColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(793, 40);
            this.headerPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ccmsLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(793, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ccmsLabel
            // 
            this.ccmsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ccmsLabel.AutoSize = true;
            this.ccmsLabel.Location = new System.Drawing.Point(3, 8);
            this.ccmsLabel.Name = "ccmsLabel";
            this.ccmsLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ccmsLabel.Size = new System.Drawing.Size(787, 24);
            this.ccmsLabel.TabIndex = 0;
            this.ccmsLabel.Text = "Community Clinic Management System (CCMS)";
            this.ccmsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(73)))), ((int)(((byte)(77)))));
            this.leftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenuPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.leftMenuPanel.ForeColor = System.Drawing.Color.White;
            this.leftMenuPanel.Location = new System.Drawing.Point(0, 40);
            this.leftMenuPanel.Name = "leftMenuPanel";
            this.leftMenuPanel.Size = new System.Drawing.Size(200, 408);
            this.leftMenuPanel.TabIndex = 0;
            // 
            // masterLayoutPanel
            // 
            this.masterLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.masterLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterLayoutPanel.ForeColor = System.Drawing.Color.White;
            this.masterLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.masterLayoutPanel.Name = "masterLayoutPanel";
            this.masterLayoutPanel.Size = new System.Drawing.Size(593, 408);
            this.masterLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.masterLayoutPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 408);
            this.panel1.TabIndex = 1;
            // 
            // MasterLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 448);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftMenuPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "MasterLayoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.headerPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel headerPanel;
        public System.Windows.Forms.Panel leftMenuPanel;
        public System.Windows.Forms.Panel masterLayoutPanel;
        private System.Windows.Forms.Label ccmsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}

