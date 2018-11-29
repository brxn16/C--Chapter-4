using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double GPA;
            double testScore;
            const int GPAMIN = 3;
            const int TESTMIN1 = 60;
            const int TESTMIN2 = 80;

            GPA = Convert.ToDouble(txtGPA.Text);
            testScore = Convert.ToDouble(txttestScore.Text);

            if (GPA >= GPAMIN && testScore >= TESTMIN1)
            {
                lblAcceptance.Text = "Congratulations!";
                lblAcceptance.ForeColor = Color.Green;
            }
           
            else if (GPA < GPAMIN && testScore >= TESTMIN2)
            {
                lblAcceptance.Text = "Congratulations!";
                lblAcceptance.ForeColor = Color.Green;
            }
            else
            {
                lblAcceptance.Text = "Rejected";
                lblAcceptance.ForeColor = Color.Red;
            }

        }
    }
}
