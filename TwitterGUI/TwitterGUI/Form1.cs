using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterGUI
{
    public partial class FormTwitter : Form
    {
        public FormTwitter()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string message;
            const int MAX = 140;

            message = txtTwitterMasg.Text;

            if (message.Length > MAX)
            {
                lblCounter.Text = message.Length + " OVER LIMIT";
                lblCounter.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                lblCounter.Text = message.Length + " Under Limit";
                lblCounter.ForeColor = System.Drawing.Color.Black;
                lblPostedMsg.Text = "Posted to Twitter"; 

            }
        }
    }
}
