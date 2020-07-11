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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Showing Information");
             this.Hide();
            ShowInformation s = new ShowInformation(txtID.Text, txtName.Text, dtnDOB.Text, txtSalary.Text, comboBoxBloodGroup.Text, radioButtonMale.Text, radioButtonFemale.Text);
            s.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text ="";
            txtName.Text ="";
            dtnDOB.Text ="";
            txtSalary.Text ="";
            comboBoxBloodGroup.Text ="";
            radioButtonMale.Checked = false;
            radioButtonMale.Checked = false;

        }

    }
}
