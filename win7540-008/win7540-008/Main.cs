using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win7540_008
{
    public partial class MainForm : Form
    {
        double priceSqMeter;
        double exchangeRate;
        double width;
        double length;
        double area;
        string material;

        public MainForm()
        {
            InitializeComponent();
            secondVisibility(false);
        }

        public void secondVisibility(bool visibility)
        {
            grpFoundations.Visible = visibility;
            txtLength.Visible = visibility;
            txtWidth.Visible = visibility;
            lblWidth.Visible = visibility;
            lblLength.Visible = visibility;
            lblGBPPrice.Visible = visibility;
            lblGBPTitle.Visible = visibility;
            lblEurTitle.Visible = visibility;
            lblEurPrice.Visible = visibility;
            lblFinalDisplay.Visible = visibility;
            btnCalculate.Visible = visibility;
            btnClear.Visible = visibility;
        }

        public void firstVisibility(bool visibility)
        {
            lblPrices.Visible = visibility;
            txtBrick.Visible = visibility;
            txtConcrete.Visible = visibility;
            txtGravel.Visible = visibility;
            txtTarmac.Visible = visibility;
            btnStart.Visible = visibility;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                exchangeRate = double.Parse(txtExchange.Text);

                switch (GetCheckedRadio(grpMaterials).Text)
                {
                    case "Brick": priceSqMeter = double.Parse(txtBrick.Text); material = "Brick" ; break;
                    case "Concrete": priceSqMeter = double.Parse(txtConcrete.Text); material = "Concrete"; break;
                    case "Tarmac": priceSqMeter = double.Parse(txtTarmac.Text); material = "Tarmac"; break;
                    case "Gravel": priceSqMeter = double.Parse(txtGravel.Text); material = "Gravel"; break;
                }

                firstVisibility(false);
                secondVisibility(true);
                grpMaterials.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Exchange Rates or Prices not entered.", "Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        RadioButton GetCheckedRadio(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked)
                {
                    return radio;
                }
            }

            return null;
        }

        private void acceptDouble(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBrick_KeyPress(object sender, KeyPressEventArgs e)
        {
            acceptDouble(sender, e);
        }

        private void txtConcrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            acceptDouble(sender, e);
        }

        private void txtTarmac_KeyPress(object sender, KeyPressEventArgs e)
        {
            acceptDouble(sender, e);
        }

        private void txtGravel_KeyPress(object sender, KeyPressEventArgs e)
        {
            acceptDouble(sender, e);
        }

        private void txtExchange_KeyPress(object sender, KeyPressEventArgs e)
        {
            acceptDouble(sender, e);
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            acceptDouble(sender, e);
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            acceptDouble(sender, e);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                exchangeRate = double.Parse(txtExchange.Text);
                width = double.Parse(txtWidth.Text);
                length = double.Parse(txtLength.Text);
                area = width * length;
                if (radStandart.Checked)
                {
                    lblGBPPrice.Text = "£" + Math.Round(area * priceSqMeter,2).ToString();
                    lblEurPrice.Text = "€" + Math.Round(area * priceSqMeter * exchangeRate,2).ToString();
                    lblFinalDisplay.Text = material + " selected with Standart Foundation";
                }
                else
                {
                    lblGBPPrice.Text = "£" + Math.Round(area * priceSqMeter * 1.25,2).ToString();
                    lblEurPrice.Text = "€" + Math.Round(area * priceSqMeter * exchangeRate * 1.25,2).ToString();
                    lblFinalDisplay.Text = material + " selected with Extra Deep Foundation";
                }
            }
            catch
            {
                MessageBox.Show("Units not valid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            secondVisibility(false);
            firstVisibility(true);
            txtLength.Text = "";
            txtWidth.Text = "";
            lblEurPrice.Text = "";
            lblGBPPrice.Text = "";
            lblFinalDisplay.Text = "";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Close Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
