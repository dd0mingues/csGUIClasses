using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winUnitConverter
{
    public partial class Form1 : Form
    {

        Boolean firstBoxSelected = true;
        int previousUnit1 = 0;
        int previousUnit2 = 4;

        //some colors
        Color ImperialRed = ColorTranslator.FromHtml("#E63946");
        Color Honeydew = ColorTranslator.FromHtml("#F1FAEE");
        Color PowderBlue = ColorTranslator.FromHtml("#A8DADC");
        Color CeladonBlue = ColorTranslator.FromHtml("#457B9D");
        Color PrussianBlue = ColorTranslator.FromHtml("#1D3557");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.BackColor = Honeydew;
            lblMainTitle.ForeColor = PrussianBlue;

            cmbType.SelectedIndex = 0;
            cmbUnit1.SelectedIndex = 0;
            cmbUnit2.SelectedIndex = 4;

            txtUnit2.Text =(Converter.convert(double.Parse(txtUnit1.Text), cmbUnit1.Text, cmbUnit2.Text)).ToString("G4");
        }

        private void txtUnit2_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtUnit1.Text = (Converter.convert(double.Parse(txtUnit2.Text), cmbUnit2.Text, cmbUnit1.Text)).ToString("G4");
                firstBoxSelected = false;
            }
            catch
            {

            }
        }

        private void txtUnit1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtUnit2.Text = (Converter.convert(double.Parse(txtUnit1.Text), cmbUnit1.Text, cmbUnit2.Text)).ToString("G4");
                firstBoxSelected = true;
            }
            catch
            {

            }
        }


        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] length = { "Kilometer", "Meter", "Centimeter", "Milimeter", "Mile", "Yard", "Foot", "Inch" };
            string[] mass = { "Kilogram", "Gram", "Stone", "Pound", "Ounce" };
            string[] temp = {"Celcius", "Fahrenheit", "Kelvin"};
            switch (cmbType.SelectedIndex)
            {
                case 0:
                    rewriteComboBoxes(length);
                    cmbUnit1.SelectedIndex = 0;
                    cmbUnit2.SelectedIndex = 4;
                    previousUnit1 = 0;
                    previousUnit2 = 4;
                    break;
                case 1:
                    rewriteComboBoxes(mass);
                    cmbUnit1.SelectedIndex = 0;
                    cmbUnit2.SelectedIndex = 3;
                    previousUnit1 = 0;
                    previousUnit2 = 3;
                    break;
                case 2:
                    rewriteComboBoxes(temp);
                    cmbUnit1.SelectedIndex = 0;
                    cmbUnit2.SelectedIndex = 1;
                    previousUnit1 = 0;
                    previousUnit2 = 1;
                    break;
            }

            txtUnit2.Text = (Converter.convert(double.Parse(txtUnit1.Text), cmbUnit1.Text, cmbUnit2.Text)).ToString("G4");
        }

        private void rewriteComboBoxes(string[] input)
        {
            cmbUnit1.Items.Clear();
            cmbUnit2.Items.Clear();
            cmbUnit1.Items.AddRange(input);
            cmbUnit2.Items.AddRange(input);
        }

 
        private void cmbUnit2_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                if (cmbUnit1.Text == cmbUnit2.Text)
                {
                    cmbUnit1.SelectedIndex = previousUnit2;
                }

                if (firstBoxSelected)
                {
                    txtUnit2.Text = (Converter.convert(double.Parse(txtUnit1.Text), cmbUnit1.Text, cmbUnit2.Text)).ToString("G4");
                }
                else
                {
                    txtUnit1.Text = (Converter.convert(double.Parse(txtUnit2.Text), cmbUnit2.Text, cmbUnit1.Text)).ToString("G4");
                }
            }
            catch
            {

            }
            previousUnit2 = cmbUnit2.SelectedIndex;
        }

        private void cmbUnit1_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                if (cmbUnit1.Text == cmbUnit2.Text)
                {
                    cmbUnit2.SelectedIndex = previousUnit1;
                }

                if (firstBoxSelected)
                {
                    txtUnit2.Text = (Converter.convert(double.Parse(txtUnit1.Text), cmbUnit1.Text, cmbUnit2.Text)).ToString("G4");
                }
                else
                {
                    txtUnit1.Text = (Converter.convert(double.Parse(txtUnit2.Text), cmbUnit2.Text, cmbUnit1.Text)).ToString("G4");
                }
            }
            catch
            {

            }
            previousUnit1 = cmbUnit1.SelectedIndex;
        }

        private void txtUnit1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtUnit2_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
