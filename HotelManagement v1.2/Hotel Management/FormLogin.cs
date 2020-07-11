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
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {

        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H57P91L\MIRAJSQL;Initial Catalog=hotelmanagement;Integrated Security=True");
        int counter = 0;
        int len = 0;
        string txt;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void timerLogin_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                counter = 0;
                labelWelcome.Text = "";
            }
            else
            {
                labelWelcome.Text = txt.Substring(0, counter);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            con.Open();

            txt = labelWelcome.Text;
            len = txt.Length;
            labelWelcome.Text = "";
            timerLogin.Start();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxLogin.Text == "Admin")
                {
                    int i = 0;
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Employee where empname = '" + txtLoginUserName.Text + "' and emppass ='" + txtLoginPass.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable DT = new DataTable();
                    SqlDataAdapter SDA = new SqlDataAdapter(cmd);
                    SDA.Fill(DT);
                    i = Convert.ToInt32(DT.Rows.Count.ToString());
                    if (i == 0)
                    {
                        MessageBox.Show("Invalid User Name and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.Hide();
                        MDIControl MDI = new MDIControl();
                        MDI.Show();
                    }
                }

                else if (comboBoxLogin.Text == "Receptionist")
                {
                    this.Hide();
                    FormGuestInfo FG = new FormGuestInfo();
                    FG.Show();
                }
                else
                { 
                    MetroFramework.MetroMessageBox.Show(this,"Your are not allowed","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }

            catch (Exception)
            {
                MessageBox.Show("Database connection Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLoginUserName.Text = "";
            txtLoginPass.Text = "";
        }
    }
}
