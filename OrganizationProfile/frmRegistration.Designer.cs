namespace OrganizationProfile
{
    partial class frmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtStudentNo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtAge = new TextBox();
            label7 = new Label();
            txtMiddleInitial = new TextBox();
            cmbPrograms = new ComboBox();
            cmbGender = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnRegister = new Button();
            txtContact = new TextBox();
            pickerBday = new DateTimePicker();
            btnFill = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(210, 20);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(96, 72);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(100, 23);
            txtStudentNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 128);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(96, 125);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 128);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(356, 125);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(119, 23);
            txtFirstName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 75);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 6;
            label5.Text = "Program";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 186);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 10;
            label6.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(96, 183);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(490, 136);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 12;
            label7.Text = "M.I";
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(520, 128);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(50, 23);
            txtMiddleInitial.TabIndex = 11;
            // 
            // cmbPrograms
            // 
            cmbPrograms.FormattingEnabled = true;
            cmbPrograms.Location = new Point(356, 72);
            cmbPrograms.Name = "cmbPrograms";
            cmbPrograms.Size = new Size(228, 23);
            cmbPrograms.TabIndex = 13;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(356, 178);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(94, 23);
            cmbGender.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(280, 181);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 14;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 235);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 16;
            label9.Text = "Birthday";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(295, 235);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 17;
            label10.Text = "Contact No.";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(240, 300);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 18;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(386, 227);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(129, 23);
            txtContact.TabIndex = 19;
            // 
            // pickerBday
            // 
            pickerBday.Location = new Point(74, 227);
            pickerBday.Name = "pickerBday";
            pickerBday.Size = new Size(200, 23);
            pickerBday.TabIndex = 20;
            // 
            // btnFill
            // 
            btnFill.Location = new Point(439, 290);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(75, 23);
            btnFill.TabIndex = 21;
            btnFill.Text = "Fill";
            btnFill.UseVisualStyleBackColor = true;
            btnFill.Click += btnFill_Click;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(629, 360);
            Controls.Add(btnFill);
            Controls.Add(pickerBday);
            Controls.Add(txtContact);
            Controls.Add(btnRegister);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(cmbGender);
            Controls.Add(label8);
            Controls.Add(cmbPrograms);
            Controls.Add(label7);
            Controls.Add(txtMiddleInitial);
            Controls.Add(label6);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtStudentNo);
            Controls.Add(label1);
            Name = "frmRegistration";
            Text = "Organization Profile";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentNo;
        private Label label2;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtFirstName;
        private Label label5;
        private Label label6;
        private TextBox txtAge;
        private Label label7;
        private TextBox txtMiddleInitial;
        private ComboBox cmbPrograms;
        private ComboBox cmbGender;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnRegister;
        private TextBox txtContact;
        private DateTimePicker pickerBday;
        private Button btnFill;
    }
}