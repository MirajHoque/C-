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

namespace HM.User
{
    public partial class FromUserRegister : Form
    {
        int count = 0;
        Connection con = new Connection();
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        public FromUserRegister()
        {
            InitializeComponent();
        }

        private void FromUserRegister_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            LoadData();

        }

        private void clearData()
        {
            txtUserRegName.Clear();
            txtUserRegUserName.Clear();
            txtUserRegAddress.Clear();
            txtUserRegEmail.Clear();
            txtUserRegPass.Clear();
            comboBoxUserRegRole.SelectedIndex = -1;
            dateTimePickerUserReg.Value = DateTime.Now;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        public bool validation()
        {
            bool result = false;

            if (string.IsNullOrEmpty(txtUserRegName.Text))
            {
                errorProviderUserReg.Clear();
                errorProviderUserReg.SetError(txtUserRegName, "Name Required");
            }
            else if (string.IsNullOrEmpty(txtUserRegUserName.Text))
            {
                errorProviderUserReg.Clear();
                errorProviderUserReg.SetError(txtUserRegUserName, "User Name Required");
            }
            else if (string.IsNullOrEmpty(txtUserRegPass.Text))
            {
                errorProviderUserReg.Clear();
                errorProviderUserReg.SetError(txtUserRegPass, "Password Required");
            }
            else if (txtUserRegPass.Text.Length < 4)
            {
                errorProviderUserReg.Clear();
                errorProviderUserReg.SetError(txtUserRegPass, "Password Minimum 4 Character Required");
            }
            else if (string.IsNullOrEmpty(txtUserRegEmail.Text))
            {
                errorProviderUserReg.Clear();
                errorProviderUserReg.SetError(txtUserRegEmail, "Email Required");
            }
            else if (comboBoxUserRegRole.SelectedIndex == -1)
            {
                errorProviderUserReg.Clear();
                errorProviderUserReg.SetError(comboBoxUserRegRole, "Address Required");
            }
            else
            {
                errorProviderUserReg.Clear();
                result = true;
            }
            return result;
        }

        private bool IfUserNameExits(string userName)
        {
            con.DataGet("Select 1 from DBUser where UserName ='" + userName + "'");
            DataTable DT = new DataTable();
            con.sda.Fill(DT);

            if (DT.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validation())
            {

                if (IfUserNameExits(txtUserRegUserName.Text))
                {
                    MessageBox.Show("User Name Already Exits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.DataSend("INSERT INTO DBUser (Name, Email, UserName, Password, Role, DOB, Address) VALUES('" + txtUserRegName.Text + "','" + txtUserRegEmail.Text + "','" + txtUserRegUserName.Text + "','" + txtUserRegPass + "','" + comboBoxUserRegRole.Text + "','" + dateTimePickerUserReg.Value.ToString("dd/MM/yyyy") + "','" + txtUserRegAddress.Text + "')");
                    MessageBox.Show("Record Saved Sucessfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    clearData();
                    LoadData();
                }
            }
        }

        private void LoadData()
        {
            con.DataGet("Select * from DBUser");
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            dataGridViewUserRegister.Rows.Clear();

            foreach (DataRow row in DT.Rows)
            {
                int n = dataGridViewUserRegister.Rows.Add();
                dataGridViewUserRegister.Rows[n].Cells["dgSno"].Value = row["UserId"].ToString();
                dataGridViewUserRegister.Rows[n].Cells["dgName"].Value = row["Name"].ToString();
                dataGridViewUserRegister.Rows[n].Cells["dgDOB"].Value = row["DOB"].ToString();
                dataGridViewUserRegister.Rows[n].Cells["dgEmail"].Value = row["Email"].ToString();
                dataGridViewUserRegister.Rows[n].Cells["dgUserName"].Value = row["UserName"].ToString();
                dataGridViewUserRegister.Rows[n].Cells["dgRole"].Value = row["Role"].ToString();
                dataGridViewUserRegister.Rows[n].Cells["dgAddress"].Value = row["Address"].ToString();
            }
        }

        private void dataGridViewUserRegister_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtUserRegName.Text = dataGridViewUserRegister.SelectedRows[0].Cells["dgName"].Value.ToString();
            txtUserRegUserName.Text = dataGridViewUserRegister.SelectedRows[0].Cells["dgUserName"].Value.ToString();
            txtUserRegEmail.Text = dataGridViewUserRegister.SelectedRows[0].Cells["dgEmail"].Value.ToString();
            txtUserRegAddress.Text = dataGridViewUserRegister.SelectedRows[0].Cells["dgAddress"].Value.ToString();
            dateTimePickerUserReg.Text = dataGridViewUserRegister.SelectedRows[0].Cells["dgDOB"].Value.ToString();
            comboBoxUserRegRole.Text = dataGridViewUserRegister.SelectedRows[0].Cells["dgRole"].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.DataSend("UPDATE DBUser SET Name ='" + txtUserRegName.Text + "', Email ='" + txtUserRegEmail.Text + "', Role ='" + comboBoxUserRegRole.Text + "', DOB ='" + dateTimePickerUserReg.Value.ToString("dd/MM/yyyy") + "', Address ='" + txtUserRegAddress.Text + "' where UserName='" + txtUserRegUserName.Text + "' ");
                MessageBox.Show("Record Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.DataSend("DELETE FROM DBUser where UserName ='" + txtUserRegUserName.Text + "'");
                MessageBox.Show("Delete Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dispaly();
        }
        public void dispaly()
        {
            count = 0;
            con.DataGet("select * from DBUser where Username='" + txtSearch.Text + "'");
            //  da = new SqlDataAdapter(cmd);
            // dt = new DataTable();
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            dataGridViewUserRegister.DataSource = DT;
            count = Convert.ToInt32(DT.Rows.Count.ToString());
            if (count == 0)
            {
                MessageBox.Show("data not found");
            }
        }

//        string dinner;
      public static string result;
        public static string item;
        public static string price;
        public static string qty;

        double payment;
        private void btnPrice_Click(object sender, EventArgs e)
        {

        }

        private void btntotalprice_Click(object sender, EventArgs e)
        {
        
            double a = double.Parse(txtPrice.Text);
            double b = double.Parse(txtQuantity.Text);
            payment = a * b;
            result = payment.ToString();
            item = txtItem.Text;
            price = txtPrice.Text;
            qty = txtQuantity.Text;
            Bills x = new Bills();
            x.Show();
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
           // comboBoxRoom.
        }
        // public  double amountToPay()
        //{
        //  double a = double.Parse(txtPrice.Text);
        // double b = double.Parse(txtQuantity.Text);
        //  payment = a * b;
        // static double result= payment;
        //  return 0;

    }
    }
  

