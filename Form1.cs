using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter9_RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.lblMsg.Text = " ";
        }

        private void ComputeCost_CheckedChanged(object sender, EventArgs e) // Example 9-21, pg 520
        {
            /*
             * A nested if-else statement here wouldn't work, because it is not known which check box
             * will be selected first. 
             */
            decimal cost = 0;
            if (this.ckBoxSwim.Checked)
            {
                cost += 50;
            }
            if (this.ckBoxSnorkel.Checked)
            {
                cost += 25;
            }
            if (this.ckBoxDive.Checked)
            {
                cost += 100;
            }

            if (this.radBeginner.Checked)
            {
                cost += 15;
                this.lblMsg.Text = "Begginer extra $15 charge";
            } else if (this.radIntermediate.Checked)
            {
                cost += 5;
                this.lblMsg.Text = "Imtermediate extra $5 charge";
            } else if (this.radAdvanced.Checked)
            {
                cost -= 15;
                this.lblMsg.Text = "Advanced $15 Discount";
            } else
            {
                this.lblMsg.Text = " ";
            }

            this.txtResult.Text = cost.ToString("C");

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
