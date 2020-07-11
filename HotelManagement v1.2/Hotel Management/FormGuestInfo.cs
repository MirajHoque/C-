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

namespace Hotel_Management
{
    public partial class FormGuestInfo : MetroFramework.Forms.MetroForm
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H57P91L\MIRAJSQL;Initial Catalog=hotelmanagement;Integrated Security=True");

        public FormGuestInfo()
        {
            InitializeComponent();
        }

        private void FormGuestInfo_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            GuestDataGrid();
        }

        private void btnGuestSave_Click(object sender, EventArgs e)
        {
            //int i = 0;
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            // cmd.CommandText = "insert into GuestInfo values('" + txtGName.Text + "','" + DateTimeGuestBirth.Value.ToString("dd-MM-yyyy") + "','" + ComboBoxGuestGender.Text + "','" + txtGuestLicense.Text + "','" + ComboBoxGType.Text + "','" + txtGContact.Text+ "','"+txtGEmail.Text+"','"+txtGAddress.Text+"')";
            //cmd.ExecuteNonQuery();
            //GuestDataGrid();

            /* DataTable DT = new DataTable();
             SqlDataAdapter SDA = new SqlDataAdapter(cmd);
             SDA.Fill(DT);*/

            // SqlCommand cmd1 = con.CreateCommand();
            // cmd1.CommandType = CommandType.Text;
            //cmd1.CommandText = "insert into GuestBooking values('" + ComboBoxGRoomType.Text + "','" + ComboBoxGFloorNo.Text + "','" + ComboBoxGRoomNo.Text + "','" + txtRoomFare.Text + "','" + txtDiscount.Text + "','" + DateTimeEntryDate.Value.ToString("dd-MM-yyyy") + "','" + DateTimeDeparture.Value.ToString("dd-MM-yyyy") + "'";
             //cmd1.ExecuteNonQuery();
            //GuestDataGrid();
            /*DataTable DT1 = new DataTable();
            SqlDataAdapter SDA1 = new SqlDataAdapter(cmd);
            SDA1.Fill(DT);*/

         //   MetroFramework.MetroMessageBox.Show(this,"Data Insert Sucessfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);


            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from GuestInfo where guestcontact = '" + txtGContact.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            i = Convert.ToInt32(DT.Rows.Count.ToString());
            if (i == 0)
            {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into GuestInfo values('" + txtGName.Text + "','" + DateTimeGuestBirth.Value.ToString("dd-MM-yyyy") + "','" + ComboBoxGuestGender.Text + "','" + txtGuestLicense.Text + "','" + ComboBoxGType.Text + "','" + txtGContact.Text+ "','"+txtGEmail.Text+"','"+txtGAddress.Text+"')";
                //cmd1.CommandText = "insert into registration values('" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + textBoxUserNameNew.Text + "','" + textBoxPasswordNew.Text + "','" + textBoxEmail.Text + "','" + textBoxContact.Text + "')";
                cmd1.ExecuteNonQuery();
//                clearData();
                MessageBox.Show("New User Add Sucessfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GuestDataGrid();
            }
            else
            {
                MessageBox.Show("User Name Already Exits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void GuestDataGrid()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from GuestInfo";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            dataGridViewGuest.DataSource = DT;
        }



    }
}
