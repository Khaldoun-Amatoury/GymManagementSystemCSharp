namespace OOD_Project___GMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean b = true;
        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\Khaldoun\Downloads\right-arrow.png");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\Khaldoun\Downloads\down-arrow.png");
            }
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStaff ns = new NewStaff();
            ns.Show();
        }

        private void newMemberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewMember nm = new NewMember();
            nm.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\Khaldoun\Downloads\down-arrow.png");
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();
            sm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will close your application. Confirm?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}