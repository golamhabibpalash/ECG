﻿namespace ECG_Analyzer
{
    partial class DoctorForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.masterLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.Size = new System.Drawing.Size(150, 410);
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(150, 429);
            this.footerPanel.Size = new System.Drawing.Size(650, 21);
            // 
            // masterLayoutPanel
            // 
            this.masterLayoutPanel.Controls.Add(this.button1);
            this.masterLayoutPanel.Controls.Add(this.label1);
            this.masterLayoutPanel.Location = new System.Drawing.Point(150, 40);
            this.masterLayoutPanel.Size = new System.Drawing.Size(650, 389);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.masterLayoutPanel.ResumeLayout(false);
            this.masterLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}