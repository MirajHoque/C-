using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;
using System.Data;

namespace Hotel_Management
{
    public partial class FormEmployee : MetroFramework.Forms.MetroForm
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H57P91L\MIRAJSQL;Initial Catalog=hotelmanagement;Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        public FormEmployee()
          
        {
            InitializeComponent();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Employee values('" + txtEname.Text+"','"+txtEcontact.Text+"','"+txtEemail.Text+"','"+dtpEDob.Text+"','"+txtEAddress.Text+ "','"+EdigCombo.Text+"','"+txtEdigpass.Text+"','"+txtEsal.Text+"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfully inserted");
            con.Close();
            displayEmpData();

        }
        public void displayEmpData()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from Employee";
           // cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvEmp.DataSource = dt;
            //cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully inserted");
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            displayEmpData();
        }

        private void btnEinfoSave_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Employee values('" + txtEname.Text + "','" + txtEcontact.Text + "','" + txtEemail.Text + "','" + dtpEDob.Text + "','" + txtEAddress.Text + "','" + EdigCombo.Text + "','" + txtEdigpass.Text + "','" + txtEsal.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfully inserted");
            con.Close();
            displayEmpData();
        }
    }
}
