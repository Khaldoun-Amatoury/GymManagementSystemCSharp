namespace OOD_Project___GMS
{
    partial class SearchMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMember));
            txtSearch = new TextBox();
            label1 = new Label();
            btn_Search = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(230, 105);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(265, 27);
            txtSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 109);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 1;
            label1.Text = "Enter ID";
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.Blue;
            btn_Search.Location = new Point(282, 153);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(94, 29);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(613, 263);
            dataGridView1.TabIndex = 3;
            // 
            // SearchMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(630, 484);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Search);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Name = "SearchMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchMember";
            Load += SearchMember_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label label1;
        private Button btn_Search;
        private DataGridView dataGridView1;
    }
}