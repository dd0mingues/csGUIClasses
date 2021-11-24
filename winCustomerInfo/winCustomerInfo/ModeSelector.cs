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
    public partial class ModeSelector : Form
    {
        CustomerManager form = new CustomerManager();

        public ModeSelector()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            form.Show();
            form.btnFunction.Text = "Add";
            
        }

        private void btnRectify_Click(object sender, EventArgs e)
        {
            form.Show();
            form.btnFunction.Text = "Rectify";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            form.Show();
            form.btnFunction.Text = "Remove";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
