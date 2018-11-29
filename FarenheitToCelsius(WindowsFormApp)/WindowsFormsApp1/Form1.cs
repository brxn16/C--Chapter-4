using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFarenheit_Click(object sender, EventArgs e)
        {
            double temp1;
            double temp2;
            double temp3;
            double conversionUno;
            double conversionDos;
            double conversionTres;
            double averageCelsius;
            double average;

            temp1 = Convert.ToDouble(txt8am.Text);
            temp2 = Convert.ToDouble(txt12pm.Text);
            temp3 = Convert.ToDouble(txt5pm.Text);

            conversionUno = temp1 * 1.8 + 32;
            conversionDos = temp2 * 1.8 + 32;
            conversionTres = temp3 * 1.8 + 32;
            averageCelsius = (temp1 + temp2 + temp3 ) / 3;
            average = (conversionUno + conversionDos + conversionTres) / 3;
            lblTemp1.Text = "" + conversionUno;
            lblTemp2.Text = "" + conversionDos;
            lblTemp3.Text = "" + conversionTres;
            lblAverageCelsius.Text = "" + averageCelsius;
            lblAverageFaren.Text = "" + average;

            if (conversionUno <= 32)
            {
                lblHotorCold1.Text = "Freezing";
            }
            else if (conversionUno >= 100)
            {
                lblHotorCold1.Text = "That's Hot";
            }
            else if (conversionDos <= 32)
            {
                lblHotorCold2.Text = "Freezing";
            }
            else if (conversionDos >= 100)
            {
                lblHotorCold2.Text = "That's Hot";
            }
            else if (conversionTres <= 32)
            {
                lblHotorCold3.Text = "Freezing";
            }
            else if (conversionTres >= 100)
            {
                lblHotorCold3.Text = "That's Hot";
            }
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            double temp1;
            double temp2;
            double temp3;
            double conversionUno;
            double conversionDos;
            double conversionTres;
            double average;
            double averageCelsius;

            temp1 = Convert.ToDouble(txt8am.Text);
            temp2 = Convert.ToDouble(txt12pm.Text);
            temp3 = Convert.ToDouble(txt5pm.Text);

            conversionUno = (temp1 - 32) / 1.8;
            conversionDos = (temp2 - 32) / 1.8;
            conversionTres = (temp3 - 32) / 1.8;
            averageCelsius = (conversionUno + conversionDos + conversionTres) / 3;
            average = (temp1 + temp2 + temp3) / 3;
            lblTemp1.Text = "" + conversionUno;
            lblTemp2.Text = "" + conversionDos;
            lblTemp3.Text = "" + conversionTres;
            lblAverageCelsius.Text = "" + averageCelsius;
            lblAverageFaren.Text = "" + average;

            if(conversionUno <= 0)
            {
                lblHotorCold1.Text = "Freezing";
            }
            else if(conversionUno >= 37.7)
            {
                lblHotorCold1.Text = "Boiling Hot";
            }
            else if (conversionDos <= 0)
            {
                lblHotorCold2.Text = "Freezing";
            }
            else if (conversionDos >= 37.7)
            {
                lblHotorCold2.Text = "Boiling Hot";
            }
            else if (conversionTres <= 0)
            {
                lblHotorCold3.Text = "Freezing";
            }
            else if (conversionTres >= 37.7)
            {
                lblHotorCold3.Text = "Boiling Hot";
            }

        }
    }
}
