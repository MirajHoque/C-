using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CalculatorProject
{
    public partial class Form1 : Form
    {
        double input1, input2, output,mod;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToDouble(textBox1_input.Text);
            input2 = Convert.ToDouble(textBox2_input.Text);
            output = input1 + input2;
            textBox3_output.Text = output.ToString();
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToDouble(textBox1_input.Text);
            input2 = Convert.ToDouble(textBox2_input.Text);
            output = input1 - input2;
            textBox3_output.Text = output.ToString();
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToDouble(textBox1_input.Text);
            input2 = Convert.ToDouble(textBox2_input.Text);
            output = input1 * input2;
            textBox3_output.Text = output.ToString();
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToDouble(textBox1_input.Text);
            input2 = Convert.ToDouble(textBox2_input.Text);
            output = input1 / input2;
            textBox3_output.Text = output.ToString();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1_input.Text = " ";
            textBox2_input.Text = " ";
            textBox3_output.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToDouble(textBox1_input.Text);
            input2 = Convert.ToDouble(textBox2_input.Text);
            mod = input1 % input2;
            textBox3_output.Text = mod.ToString();
        }

       
    }
}
