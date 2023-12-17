namespace OOD_Project___GMS
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEquipName = new TextBox();
            txtMusclesUsed = new TextBox();
            txtCost = new TextBox();
            txtDescription = new RichTextBox();
            dateTimePickerDeliveryDate = new DateTimePicker();
            btnSave = new Button();
            btnReset = new Button();
            btnViewEqp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(173, 63);
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
            label1.TabIndex = 0;
            label1.Text = "Equipment Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(173, 151);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(173, 245);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 2;
            label3.Text = "Muscles Used";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(173, 303);
            label4.Name = "label4";
            label4.Size = new Size(113, 19);
            label4.TabIndex = 3;
            label4.Text = "Delivery Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(173, 354);
            label5.Name = "label5";
            label5.Size = new Size(46, 19);
            label5.TabIndex = 4;
            label5.Text = "Cost";
            // 
            // txtEquipName
            // 
            txtEquipName.Location = new Point(331, 57);
            txtEquipName.Name = "txtEquipName";
            txtEquipName.Size = new Size(192, 27);
            txtEquipName.TabIndex = 5;
            // 
            // txtMusclesUsed
            // 
            txtMusclesUsed.Location = new Point(331, 239);
            txtMusclesUsed.Name = "txtMusclesUsed";
            txtMusclesUsed.Size = new Size(192, 27);
            txtMusclesUsed.TabIndex = 6;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(331, 344);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(192, 27);
            txtCost.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(331, 96);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(192, 120);
            txtDescription.TabIndex = 8;
            txtDescription.Text = "";
            // 
            // dateTimePickerDeliveryDate
            // 
            dateTimePickerDeliveryDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDeliveryDate.Location = new Point(331, 295);
            dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            dateTimePickerDeliveryDate.Size = new Size(192, 27);
            dateTimePickerDeliveryDate.TabIndex = 9;
            dateTimePickerDeliveryDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(177, 427);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(280, 426);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnViewEqp
            // 
            btnViewEqp.Location = new Point(380, 426);
            btnViewEqp.Name = "btnViewEqp";
            btnViewEqp.Size = new Size(143, 29);
            btnViewEqp.TabIndex = 12;
            btnViewEqp.Text = "View Equipment";
            btnViewEqp.UseVisualStyleBackColor = true;
            btnViewEqp.Click += btnViewEqp_Click;
            // 
            // Equipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(630, 484);
            Controls.Add(btnViewEqp);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(dateTimePickerDeliveryDate);
            Controls.Add(txtDescription);
            Controls.Add(txtCost);
            Controls.Add(txtMusclesUsed);
            Controls.Add(txtEquipName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Equipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEquipName;
        private TextBox txtMusclesUsed;
        private TextBox txtCost;
        private RichTextBox txtDescription;
        private DateTimePicker dateTimePickerDeliveryDate;
        private Button btnSave;
        private Button btnReset;
        private Button btnViewEqp;
    }
}