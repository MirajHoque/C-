using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        int value = 0;
        string result = "";
        bool press = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBoxScreen.Text == "0")||(press))
            { textBoxScreen.Clear(); }
            press = false;
            Button b = (Button)sender;
            textBoxScreen.Text = textBoxScreen.Text + b.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = "0";
        }

        private void Oparation_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result = b.Text;
            value = int.Parse(textBoxScreen.Text);
            press = true;
        }

        private void buttonEqal_Click(object sender, EventArgs e)
        {
           
            switch (result)
            {
                case "+":
                    {
                        textBoxScreen.Text = (value + int.Parse(textBoxScreen.Text)).ToString();
                        break;
                    }
                case "-":
                    {
                        textBoxScreen.Text = (value - int.Parse(textBoxScreen.Text)).ToString();
                        break;
                    }
                case "*":
                    {
                        textBoxScreen.Text = (value * int.Parse(textBoxScreen.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        textBoxScreen.Text = (value / int.Parse(textBoxScreen.Text)).ToString();
                        break;
                    }  
            }
            
        }
    }
}
