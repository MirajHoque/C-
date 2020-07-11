using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.DataGet("Select * from DBUser where UserName ='"+txtLoginUserName.Text+"'and Password ='"+txtLoginPass.Text+"'");
            DataTable DT = new DataTable();
            con.sda.Fill(DT);

            if (DT.Rows.Count>0)
            {
                this.Hide();
                MDIControl MDI = new MDIControl();
                MDI.Show();

            }
            else
            {
                MessageBox.Show("Invalid user name and password.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
