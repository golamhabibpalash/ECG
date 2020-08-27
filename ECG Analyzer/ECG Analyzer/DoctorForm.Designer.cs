namespace ECG_Analyzer
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nameLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.specialistCBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dobBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rolCBox = new System.Windows.Forms.ComboBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTBox = new System.Windows.Forms.TextBox();
            this.genderCheckBox = new System.Windows.Forms.CheckedListBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bloodGroupTBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailTBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.headerPanel.SuspendLayout();
            this.leftMenuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.Size = new System.Drawing.Size(794, 40);
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.Controls.Add(this.panel2);
            this.leftMenuPanel.Size = new System.Drawing.Size(250, 602);
            // 
            // masterLayoutPanel
            // 
            this.masterLayoutPanel.BackColor = System.Drawing.Color.White;
            this.masterLayoutPanel.Size = new System.Drawing.Size(544, 602);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 602);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.nameLable);
            this.flowLayoutPanel1.Controls.Add(this.nameTBox);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.specialistCBox);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.dobBox);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.rolCBox);
            this.flowLayoutPanel1.Controls.Add(this.locationLabel);
            this.flowLayoutPanel1.Controls.Add(this.locationTBox);
            this.flowLayoutPanel1.Controls.Add(this.genderCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.addressLabel);
            this.flowLayoutPanel1.Controls.Add(this.addressTBox);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.bloodGroupTBox);
            this.flowLayoutPanel1.Controls.Add(this.phoneLabel);
            this.flowLayoutPanel1.Controls.Add(this.emailTBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 602);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(3, 0);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(38, 14);
            this.nameLable.TabIndex = 0;
            this.nameLable.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Specialist In";
            // 
            // specialistCBox
            // 
            this.specialistCBox.DisplayMember = "Orthopedic";
            this.specialistCBox.FormattingEnabled = true;
            this.specialistCBox.Items.AddRange(new object[] {
            "Orthopedic",
            "Surgeon",
            "Allergy and Immunology",
            "Allergy and Immunology.",
            "Anesthesiology.",
            "Colon and Rectal Surgery.",
            "Dermatology.",
            "Emergency Medicine.",
            "Family Medicine.",
            "Internal Medicine.",
            "Medical Genetics and Genomics.",
            "Surgery"});
            this.specialistCBox.Location = new System.Drawing.Point(3, 59);
            this.specialistCBox.Name = "specialistCBox";
            this.specialistCBox.Size = new System.Drawing.Size(241, 22);
            this.specialistCBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date of Birth";
            // 
            // dobBox
            // 
            this.dobBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobBox.Location = new System.Drawing.Point(3, 101);
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(241, 22);
            this.dobBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Role";
            // 
            // rolCBox
            // 
            this.rolCBox.FormattingEnabled = true;
            this.rolCBox.Items.AddRange(new object[] {
            "Employee",
            "Admin",
            "Doctor"});
            this.rolCBox.Location = new System.Drawing.Point(3, 143);
            this.rolCBox.Name = "rolCBox";
            this.rolCBox.Size = new System.Drawing.Size(241, 22);
            this.rolCBox.TabIndex = 18;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(3, 168);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(53, 14);
            this.locationLabel.TabIndex = 10;
            this.locationLabel.Text = "Location";
            // 
            // locationTBox
            // 
            this.locationTBox.Location = new System.Drawing.Point(3, 185);
            this.locationTBox.Name = "locationTBox";
            this.locationTBox.Size = new System.Drawing.Size(241, 22);
            this.locationTBox.TabIndex = 11;
            // 
            // genderCheckBox
            // 
            this.genderCheckBox.FormattingEnabled = true;
            this.genderCheckBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderCheckBox.Location = new System.Drawing.Point(3, 213);
            this.genderCheckBox.Name = "genderCheckBox";
            this.genderCheckBox.Size = new System.Drawing.Size(241, 55);
            this.genderCheckBox.TabIndex = 19;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(3, 271);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(50, 14);
            this.addressLabel.TabIndex = 12;
            this.addressLabel.Text = "Address";
            // 
            // addressTBox
            // 
            this.addressTBox.Location = new System.Drawing.Point(3, 288);
            this.addressTBox.Multiline = true;
            this.addressTBox.Name = "addressTBox";
            this.addressTBox.Size = new System.Drawing.Size(241, 88);
            this.addressTBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 20;
            this.label1.Tag = "";
            this.label1.Text = "Blood Group";
            // 
            // bloodGroupTBox
            // 
            this.bloodGroupTBox.Location = new System.Drawing.Point(3, 396);
            this.bloodGroupTBox.Name = "bloodGroupTBox";
            this.bloodGroupTBox.Size = new System.Drawing.Size(241, 22);
            this.bloodGroupTBox.TabIndex = 15;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(3, 421);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(34, 14);
            this.phoneLabel.TabIndex = 14;
            this.phoneLabel.Tag = "";
            this.phoneLabel.Text = "Email";
            // 
            // emailTBox
            // 
            this.emailTBox.Location = new System.Drawing.Point(3, 438);
            this.emailTBox.Name = "emailTBox";
            this.emailTBox.Size = new System.Drawing.Size(241, 22);
            this.emailTBox.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 1;
            // 
            // nameTBox
            // 
            this.nameTBox.Location = new System.Drawing.Point(3, 17);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(241, 22);
            this.nameTBox.TabIndex = 24;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 642);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.headerPanel.ResumeLayout(false);
            this.leftMenuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationTBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox bloodGroupTBox;
        private System.Windows.Forms.ComboBox specialistCBox;
        private System.Windows.Forms.DateTimePicker dobBox;
        private System.Windows.Forms.ComboBox rolCBox;
        private System.Windows.Forms.CheckedListBox genderCheckBox;
        private System.Windows.Forms.TextBox emailTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTBox;
    }
}