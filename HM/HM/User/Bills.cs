using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM.User
{
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            lblItemName.Text = FromUserRegister.item;
            lblPrice.Text = FromUserRegister.price;
            lblGetQty.Text = FromUserRegister.qty;

        lblBills.Text= FromUserRegister.result;
        }
    }
}
