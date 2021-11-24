using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winBrickWall
{
    public partial class Form1 : Form
    {

        const double brickArea = 0.02;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLenght_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double area = double.Parse(txtHeight.Text) * double.Parse(txtLenght.Text);
                int nrBricks = (int)(area / brickArea);

                if (chkDouble.Checked == true)
                {
                    nrBricks *= 2;
                }

                lblResult.Text = nrBricks.ToString();
            }
            catch
            {
                MessageBox.Show("Something is wrong. Check your inputs.");
            }
        }
    }
}
