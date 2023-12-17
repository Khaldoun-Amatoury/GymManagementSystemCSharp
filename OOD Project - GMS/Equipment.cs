using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace OOD_Project___GMS
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String EquipName = txtEquipName.Text;
            String Description = txtDescription.Text;
            String MUsed = txtMusclesUsed.Text;
            String DDate = dateTimePickerDeliveryDate.Text;
            Int64 cost = Int64.Parse(txtCost.Text);


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-U6A2NSC\\SQLEXPRESS; database = gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Equipment (EquipName,EDescription,MUsed,DDate,Cost) values ('" + EquipName + "' , '" + Description + "','" + MUsed + "','" + DDate + "', " + cost + ")";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            DA.Fill(Ds);
            MessageBox.Show("Data Saved.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEquipName.Clear();
            txtDescription.Clear();
            txtMusclesUsed.Clear();
            txtCost.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;
        }

        private void btnViewEqp_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }
    }
}
