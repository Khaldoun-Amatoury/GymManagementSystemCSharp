using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project___GMS
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtMobile.Clear();
            txtEmail.Clear();

            comboBoxGymTime.ResetText();
            comboBoxMembership.ResetText();

            txtAddress.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String fname = txtFirstName.Text;
            String lname = txtLastName.Text;

            String gender = "";

            bool isChecked = radioButton1.Checked;

            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String joinDate = dateTimePickerJoinDate.Text;
            String gymTime = comboBoxGymTime.Text;
            String address = txtAddress.Text;
            String membership = comboBoxMembership.Text;




            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-U6A2NSC\\SQLEXPRESS; database = gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewMember (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,GymTime,Maddress,MembershipTime) values ('" + fname + "' , '" + lname + "','" + gender + "','" + dob + "', " + mobile + ", '" + email + "','" + joinDate + "','" + gymTime + "','" + address + "','" + membership + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            DA.Fill(Ds);
            MessageBox.Show("Data Saved.");
        }
    }
}
