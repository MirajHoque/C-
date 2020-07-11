using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsForRegistration
{
    public partial class ShowInformation : Form
    {
        public ShowInformation(string id,string name,string dob,string salary,string bg,string male,string female)
        {
            lblSID.Text = id;
            lBLSName.Text = name;
            lblSDOB.Text = dob;
            lblSSalary.Text = salary;
            lblSBloodGroup.Text = bg;
            lblSGender.Text = male;
            lblSGender.Text = female;


            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
     public void show()
        {
           Convert.ToInt32(lblSSalary.Text);
        //    lblAge=

        }
    }
}
