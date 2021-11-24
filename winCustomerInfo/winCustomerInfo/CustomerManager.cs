using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winCustomerInfo
{
    public partial class CustomerManager : Form
    {
        List<Customer> lstCustomer = new List<Customer>();

        public CustomerManager()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtCounty.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";
            this.Hide();
        }

        private void CustomerManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (btnFunction.Text.Equals("Add"))
            {
                lstCustomer.Add(new Customer(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtCounty.Text));

                int n = dgridCustomers.Rows.Add();
                dgridCustomers.Rows[n].Cells[0].Value = lstCustomer[n].FName;
                dgridCustomers.Rows[n].Cells[1].Value = lstCustomer[n].LName;
                dgridCustomers.Rows[n].Cells[2].Value = lstCustomer[n].PhNbr;
                dgridCustomers.Rows[n].Cells[3].Value = lstCustomer[n].County;

            }else if (btnFunction.Text.Equals("Rectify"))
            {
                int n = dgridCustomers.CurrentRow.Index;

                lstCustomer[n].FName = txtFirstName.Text;
                lstCustomer[n].LName = txtLastName.Text;
                lstCustomer[n].PhNbr = txtPhoneNumber.Text;
                lstCustomer[n].County = txtCounty.Text;

                dgridCustomers.Rows[n].Cells[0].Value = lstCustomer[n].FName;
                dgridCustomers.Rows[n].Cells[1].Value = lstCustomer[n].LName;
                dgridCustomers.Rows[n].Cells[2].Value = lstCustomer[n].PhNbr;
                dgridCustomers.Rows[n].Cells[3].Value = lstCustomer[n].County;
            }
            else if (btnFunction.Text.Equals("Remove"))
            {
                dgridCustomers.Rows.Remove(dgridCustomers.CurrentRow);
            }
        }
    }
}
