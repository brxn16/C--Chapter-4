using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace HurricaneGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHurricane_Click(object sender, EventArgs e)
        {
            double speed;
            int Cat1 = 74;
            int Cat2 = 96;
            int Cat3 = 111;
            int Cat4 = 130;
            int Cat5 = 157;

            speed = Convert.ToDouble(txtSpeed.Text);

            if (speed < Cat1)
            {
                lblCategory.Text = "Not a Hurricane";
            }
            else if (speed >= Cat1 && speed < Cat2)
            {
                lblCategory.Text = "Category 1";
            }
            else if (speed >= Cat2 && speed < Cat3)
            {
                lblCategory.Text = "Category 2";
            }
            else if (speed >= Cat3 && speed < Cat4)
            {
                lblCategory.Text = "Category 3";
            }
            else if (speed >= Cat4 && speed < Cat5)
            {
                lblCategory.Text = "Category 4";
            }
            else if (speed >= Cat5)
            {
                lblCategory.Text = "Category 5";
            }

        }
    }
}
