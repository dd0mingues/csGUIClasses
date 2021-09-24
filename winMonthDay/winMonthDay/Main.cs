using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winMonthDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMonths.Text)
            {
                //case "January": txtDays.Text = "31";break;
                //case "February": txtDays.Text = "28";break;
                //case "March": txtDays.Text = "31";break;
                //case "April": txtDays.Text = "30";break;
                //case "May":txtDays.Text = "31";break;
                //case "June":txtDays.Text = "30";break;
                //case "July":txtDays.Text = "31";break;
                //case "August":txtDays.Text = "31";break;
                //case "September":txtDays.Text = "30";break;
                //case "October":txtDays.Text = "31";break;
                //case "November":txtDays.Text = "30";break;
                //case "December":txtDays.Text = "31";break;

                case "January":
                case "March":
                case "May":
                case "July":
                case "August":
                case "October":
                case "December":txtDays.Text = "31";break ;

                case "April":
                case "June":
                case "September":
                case "November": txtDays.Text = "30";break;

                case "February": txtDays.Text = "28";break;

            }

            switch (cmbMonths.Text)
            {
                case "December":
                case "January":
                case "February": txtSeason.Text = "Winter";
                    imgSeason.Image = Properties.Resources.winter; break;

                case "March":
                case "April":
                case "May": txtSeason.Text = "Spring";
                    imgSeason.Image = Properties.Resources.spring; break;

                case "June":
                case "July":
                case "August": txtSeason.Text = "Summer";
                    imgSeason.Image = Properties.Resources.summer; break;

                case "September":
                case "October":
                case "November": txtSeason.Text = "Outumn";
                    imgSeason.Image = Properties.Resources.outumn; break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDays.Enabled = false;
            txtSeason.Enabled = false;
        }
    }
}
