namespace OOD_Project___GMS
{
    partial class DeleteMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMember));
            label_EnterID = new Label();
            txt_Delete = new TextBox();
            btn_Delete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_EnterID
            // 
            label_EnterID.AutoSize = true;
            label_EnterID.Location = new Point(167, 89);
            label_EnterID.Name = "label_EnterID";
            label_EnterID.Size = new Size(62, 20);
            label_EnterID.TabIndex = 0;
            label_EnterID.Text = "Enter ID";
            label_EnterID.Click += label1_Click;
            // 
            // txt_Delete
            // 
            txt_Delete.Location = new Point(244, 86);
            txt_Delete.Name = "txt_Delete";
            txt_Delete.Size = new Size(258, 27);
            txt_Delete.TabIndex = 1;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(265, 138);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 29);
            btn_Delete.TabIndex = 2;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(609, 289);
            dataGridView1.TabIndex = 3;
            // 
            // DeleteMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(630, 484);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Delete);
            Controls.Add(txt_Delete);
            Controls.Add(label_EnterID);
            Name = "DeleteMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteMember";
            Load += DeleteMember_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_EnterID;
        private TextBox txt_Delete;
        private Button btn_Delete;
        private DataGridView dataGridView1;
    }
}