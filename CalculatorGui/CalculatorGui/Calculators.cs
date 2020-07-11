using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGui
{
    public partial class Calculators : Form
    {
        double result = 0;
        string operation = "";
        bool operationPerformed = false;
        public Calculators()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtResult.Text = "0";
            result = 0;
        }

        private void btnD1_Click(object sender, EventArgs e)
        {

            if ((txtResult.Text == "0") || (operationPerformed))
                txtResult.Clear();
            // (Int32) txtResult.Text =(Int32)txtResult.AppendText("1");
            // txtResult.Text = txtResult.AppendText(1);

            txtResult.Text = txtResult.Text + "1";

        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operationPerformed))
                txtResult.Clear();

            txtResult.Text = txtResult.Text + "2";

        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operationPerformed))
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "3";

        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operationPerformed))
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "4";

        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operationPerformed))
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "5";

        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operationPerformed))
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "6";

        }

        private void btnD7_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operationPerformed))
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "7";

        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operationPerformed))
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "8";

        }

        private void btnD9_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operationPerformed))
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "9";

        }

        private void btnDzero_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operationPerformed))
                txtResult.Clear();

            txtResult.Text = txtResult.Text + "0";

        }

        private void btnDdot_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operationPerformed))
                txtResult.Clear();

            txtResult.Text = txtResult.Text + ".";

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {

            operation = btnAddition.Text;
            result = Convert.ToDouble(txtResult.Text);
            operationPerformed = true;

        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {

            operation = btnSubtraction.Text;
            result = Convert.ToDouble(txtResult.Text);
            operationPerformed = true;
        }

        private void btnMultification_Click(object sender, EventArgs e)
        {

            operation = btnMultification.Text;
            result = Convert.ToDouble(txtResult.Text);
            operationPerformed = true;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

            operation = btnDivision.Text;
            result = Convert.ToDouble(txtResult.Text);
            operationPerformed = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operationPerformed = false;

            switch (operation)
            {
                case "+":
                    txtResult.Text = (result + Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (result - Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (result * Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (result / Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                case "%":
                    txtResult.Text = (result % Convert.ToInt16(txtResult.Text)).ToString();
                    break;
                default:
                    break;

            }
            operationPerformed = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            result = 0;
            // txtResult.Text =( txtResult.AppendText(0)).Tostring();
        }

      /*  private void button1_Click(object sender, EventArgs e)
        {

            operation = btnDivision.Text;
            result = Convert.ToDouble(txtResult.Text);
            operationPerformed = true;

        }*/

    }
}
