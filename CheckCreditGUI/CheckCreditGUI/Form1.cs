using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckCreditGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            double purchase;
            const int MAX = 5000;

            purchase = Convert.ToDouble(txtPrice.Text);
            
            if (purchase > MAX)
            {
                lblTransaction.Text = "DECLINED";
                lblTransaction.ForeColor = Color.Red;
            }
            else
            {
                lblTransaction.Text = "APPROVED";
                lblTransaction.ForeColor = Color.Green;
            }
        }
    }
}
