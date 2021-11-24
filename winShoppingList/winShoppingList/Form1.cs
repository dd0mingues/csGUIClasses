using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newShoppingList
{
    public partial class Form1 : Form
    {

        double totalPrice = 0;
        double subtotal = 0;
        double taxTotal = 0;
        public Form1()
        {
            InitializeComponent();
            btnCheckOut.Enabled = false;

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                subtotal = double.Parse(txtQuantity.Text) * itemList[lstItems.SelectedIndex].Price;
                lblSubtotal.Text = "€" + string.Format("{0:N2}", subtotal);
            }
            catch {
                subtotal = 0;
                lblSubtotal.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                btnCheckOut.Enabled = true;
                totalPrice += subtotal;
                lblTotal.Text = "€" + string.Format("{0:N2}", totalPrice);
                clear();
                taxTotal = totalPrice - totalPrice / 1.25;
                lblVat.Text = "€" + string.Format("{0:N2}", taxTotal);
            }
            catch { }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Your total due is: €" + string.Format("{0:N2}", totalPrice));
                clear();
                btnCheckOut.Enabled = false;
                 totalPrice = 0;
                 subtotal = 0;
                 taxTotal = 0;
                btnAdd_Click(null, null);
            }
            catch { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        List<Item> itemList = Item.addItems("Tea bags 2.50; Milk 1.99; Eggs 1.60; Potatoes 5.50; Carrots 1.00; Fish 6.50; Beef  4.50; Chicken 4.99");

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                subtotal = double.Parse(txtQuantity.Text) * itemList[lstItems.SelectedIndex].Price;
                lblSubtotal.Text = string.Format("{0:N2}",subtotal);
            }
            catch
            {
                subtotal = 0;
                lblSubtotal.Text = "";
            }

            try
            {
                lblPrice.Text = "€" + string.Format("{0:N2}", itemList[lstItems.SelectedIndex].Price);
                switch (lstItems.SelectedIndex)
                {
                    case 0: imgItem.Image = Properties.Resources.teaBags; break;
                    case 1: imgItem.Image = Properties.Resources.milk; break;
                    case 2: imgItem.Image = Properties.Resources.eggs; break;
                    case 3: imgItem.Image = Properties.Resources.potatoes; break;
                    case 4: imgItem.Image = Properties.Resources.carrots; break;
                    case 5: imgItem.Image = Properties.Resources.fish; break;
                    case 6: imgItem.Image = Properties.Resources.Beef; break;
                    case 7: imgItem.Image = Properties.Resources.Chicken; break;
                }
            }
            catch
            {
                lblPrice.Text = "";
            }
        }
            
        private void clear()
        {
            try
            {
                txtQuantity.Text = "";
                lstItems.ClearSelected();
            }
            catch
            {

            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
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
