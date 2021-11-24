using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winEnsuranceCalculator
{
    public partial class Form1 : Form
    {

        double ageMultiplier = 1;
        double claimMultiplier = 1;
        double premium = 500;

        public Form1()
        {
            InitializeComponent();
            btnCompute.Enabled = false;
        }

        private void dateBirthday_ValueChanged(object sender, EventArgs e)
        {
            double timeLenght = (DateTime.Today - dateBirthday.Value).TotalDays;
            double days17years = 6205;
            double days25years = 9125;


            if (timeLenght < days17years)
            {
                btnCompute.Enabled = false;
            }
            else if (days17years <= timeLenght)
            {
                btnCompute.Enabled = true;

                if (timeLenght < days25years)
                {
                    ageMultiplier = 1.2;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Honeydew;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (chkClaim.Checked == true)
            {
                claimMultiplier = 1.3;
            }
            else
            {
                claimMultiplier = 1;
            }
            
            if(radThird.Checked == true)
            {
                premium = 500;
            }
            else
            {
                premium = 1000;
            }

            lblValue.Text = (premium * ageMultiplier * claimMultiplier).ToString();
         }
    }
}
