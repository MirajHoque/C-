using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data;

namespace dbInformation
{
    public partial class Information : Form
    {
        public SqlConnection con=new SqlConnection(@" Data Source=DESKTOP-H57P91L\MIRAJSQL;Initial Catalog=TestDb;Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
      

        
        public Information()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into information values('" + txtName.Text + "','" + txtCity.Text + "','" + txtCountry.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("seuccefully inserted");
            con.Close();
            displayData();

        }
        public void displayData()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from information";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvinfo.DataSource = dt;
            //cmd.ExecuteNonQuery();
            con.Close();
           // MessageBox.Show("seuccefully inserted");
        }

        private void Information_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
