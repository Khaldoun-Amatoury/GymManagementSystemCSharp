namespace OOD_Project___GMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            newMemberToolStripMenuItem1 = new ToolStripMenuItem();
            nToolStripMenuItem = new ToolStripMenuItem();
            equipmentToolStripMenuItem = new ToolStripMenuItem();
            searchMemberToolStripMenuItem = new ToolStripMenuItem();
            deleteMemberToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, newMemberToolStripMenuItem1, nToolStripMenuItem, equipmentToolStripMenuItem, searchMemberToolStripMenuItem, deleteMemberToolStripMenuItem, logOutToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1212, 72);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 68);
            toolStripMenuItem1.Click += newMemberToolStripMenuItem_Click;
            // 
            // newMemberToolStripMenuItem1
            // 
            newMemberToolStripMenuItem1.BackColor = Color.Silver;
            newMemberToolStripMenuItem1.Image = (Image)resources.GetObject("newMemberToolStripMenuItem1.Image");
            newMemberToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            newMemberToolStripMenuItem1.Name = "newMemberToolStripMenuItem1";
            newMemberToolStripMenuItem1.Size = new Size(177, 68);
            newMemberToolStripMenuItem1.Text = "New Member";
            newMemberToolStripMenuItem1.Click += newMemberToolStripMenuItem1_Click;
            // 
            // nToolStripMenuItem
            // 
            nToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            nToolStripMenuItem.Image = (Image)resources.GetObject("nToolStripMenuItem.Image");
            nToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            nToolStripMenuItem.Name = "nToolStripMenuItem";
            nToolStripMenuItem.Size = new Size(152, 68);
            nToolStripMenuItem.Text = "New Staff";
            nToolStripMenuItem.Click += nToolStripMenuItem_Click;
            // 
            // equipmentToolStripMenuItem
            // 
            equipmentToolStripMenuItem.BackColor = Color.Silver;
            equipmentToolStripMenuItem.Image = (Image)resources.GetObject("equipmentToolStripMenuItem.Image");
            equipmentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            equipmentToolStripMenuItem.Size = new Size(159, 68);
            equipmentToolStripMenuItem.Text = "Equipment";
            equipmentToolStripMenuItem.Click += equipmentToolStripMenuItem_Click;
            // 
            // searchMemberToolStripMenuItem
            // 
            searchMemberToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            searchMemberToolStripMenuItem.Image = (Image)resources.GetObject("searchMemberToolStripMenuItem.Image");
            searchMemberToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            searchMemberToolStripMenuItem.Name = "searchMemberToolStripMenuItem";
            searchMemberToolStripMenuItem.Size = new Size(191, 68);
            searchMemberToolStripMenuItem.Text = "Search Member";
            searchMemberToolStripMenuItem.Click += searchMemberToolStripMenuItem_Click;
            // 
            // deleteMemberToolStripMenuItem
            // 
            deleteMemberToolStripMenuItem.BackColor = Color.Silver;
            deleteMemberToolStripMenuItem.Image = (Image)resources.GetObject("deleteMemberToolStripMenuItem.Image");
            deleteMemberToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            deleteMemberToolStripMenuItem.Size = new Size(191, 68);
            deleteMemberToolStripMenuItem.Text = "Delete Member";
            deleteMemberToolStripMenuItem.Click += deleteMemberToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            logOutToolStripMenuItem.Image = (Image)resources.GetObject("logOutToolStripMenuItem.Image");
            logOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(140, 68);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.Silver;
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(111, 68);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1212, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem newMemberToolStripMenuItem1;
        private ToolStripMenuItem nToolStripMenuItem;
        private ToolStripMenuItem equipmentToolStripMenuItem;
        private ToolStripMenuItem searchMemberToolStripMenuItem;
        private ToolStripMenuItem deleteMemberToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}