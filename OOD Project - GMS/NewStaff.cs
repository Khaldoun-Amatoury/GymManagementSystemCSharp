using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project___GMS
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String fname = txtFname.Text;
            String lname = txtLname.Text;

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
            Int64 mobile = Int64.Parse(txtMob.Text);
            String email = textEmail.Text;
            String joinDate = dateTimePickerJoinDate.Text;
            String state = txtState.Text;
            String city = txtCity.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-U6A2NSC\\SQLEXPRESS; database = gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewStaff (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Statee, City) values ('" + fname + "' , '" + lname + "','" + gender + "','" + dob + "', " + mobile + ", '" + email + "','" + joinDate + "','" + state + "','" + city + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            DA.Fill(Ds);
            MessageBox.Show("Data Saved.");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtMob.Clear(); 
            textEmail.Clear();
            txtCity.Clear();
            txtState.Clear(); 

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
        }
    }
}
