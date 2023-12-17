namespace OOD_Project___GMS
{
    partial class NewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMember));
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePickerDOB = new DateTimePicker();
            txtEmail = new TextBox();
            dateTimePickerJoinDate = new DateTimePicker();
            comboBoxGymTime = new ComboBox();
            txtAddress = new RichTextBox();
            txtMobile = new TextBox();
            comboBoxMembership = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnSave = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(151, 114);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 0;
            txtFirstName.TextChanged += textBox1_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(151, 167);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Location = new Point(151, 225);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Location = new Point(217, 225);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(151, 273);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(125, 27);
            dateTimePickerDOB.TabIndex = 4;
            dateTimePickerDOB.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(458, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 5;
            // 
            // dateTimePickerJoinDate
            // 
            dateTimePickerJoinDate.Format = DateTimePickerFormat.Short;
            dateTimePickerJoinDate.Location = new Point(458, 163);
            dateTimePickerJoinDate.Name = "dateTimePickerJoinDate";
            dateTimePickerJoinDate.Size = new Size(122, 27);
            dateTimePickerJoinDate.TabIndex = 6;
            // 
            // comboBoxGymTime
            // 
            comboBoxGymTime.FormattingEnabled = true;
            comboBoxGymTime.Items.AddRange(new object[] { "06AM - 07AM", "07AM - 08AM", "08AM - 09AM", "05PM - 06PM", "06PM - 07PM" });
            comboBoxGymTime.Location = new Point(458, 219);
            comboBoxGymTime.Name = "comboBoxGymTime";
            comboBoxGymTime.Size = new Size(151, 28);
            comboBoxGymTime.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(458, 273);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(151, 69);
            txtAddress.TabIndex = 8;
            txtAddress.Text = "";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(151, 315);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(125, 27);
            txtMobile.TabIndex = 9;
            // 
            // comboBoxMembership
            // 
            comboBoxMembership.FormattingEnabled = true;
            comboBoxMembership.Items.AddRange(new object[] { "1 Month", "2 Month", "3 Month", "6 Month", "12 Month" });
            comboBoxMembership.Location = new Point(269, 387);
            comboBoxMembership.Name = "comboBoxMembership";
            comboBoxMembership.Size = new Size(151, 28);
            comboBoxMembership.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(36, 118);
            label1.Name = "label1";
            label1.Size = new Size(94, 19);
            label1.TabIndex = 11;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(36, 171);
            label2.Name = "label2";
            label2.Size = new Size(92, 19);
            label2.TabIndex = 12;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(36, 228);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 13;
            label3.Text = "Gender";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(36, 279);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 14;
            label4.Text = "Date of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(36, 319);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 15;
            label5.Text = "Mobile";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(360, 117);
            label6.Name = "label6";
            label6.Size = new Size(51, 19);
            label6.TabIndex = 16;
            label6.Text = "Email";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(360, 169);
            label7.Name = "label7";
            label7.Size = new Size(83, 19);
            label7.TabIndex = 17;
            label7.Text = "Join Date";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(360, 228);
            label8.Name = "label8";
            label8.Size = new Size(87, 19);
            label8.TabIndex = 18;
            label8.Text = "Gym Time";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(360, 281);
            label9.Name = "label9";
            label9.Size = new Size(74, 19);
            label9.TabIndex = 19;
            label9.Text = "Address";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(269, 365);
            label10.Name = "label10";
            label10.Size = new Size(146, 19);
            label10.TabIndex = 20;
            label10.Text = "Membership Time";
            label10.Click += label10_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(269, 431);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(63, 30);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(357, 431);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(63, 30);
            btnReset.TabIndex = 22;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button2_Click;
            // 
            // NewMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(630, 484);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxMembership);
            Controls.Add(txtMobile);
            Controls.Add(txtAddress);
            Controls.Add(comboBoxGymTime);
            Controls.Add(dateTimePickerJoinDate);
            Controls.Add(txtEmail);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "NewMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePickerDOB;
        private TextBox txtEmail;
        private DateTimePicker dateTimePickerJoinDate;
        private ComboBox comboBoxGymTime;
        private RichTextBox txtAddress;
        private TextBox txtMobile;
        private ComboBox comboBoxMembership;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnSave;
        private Button btnReset;
    }
}