using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinHelloWorld
{
    public partial class lstFirstList : Form
    {
        public lstFirstList()
        {
            InitializeComponent();
        }

        private void btnPressMe_Click(object sender, EventArgs e)
        {
            txtIO.Text = "Hello Carlow";
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            txtIO.ForeColor = Color.Yellow;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            txtIO.ForeColor = Color.Green;
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Message Example","Information");
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIO.Text = lstNames.SelectedItem.ToString();
        }

        private void btnRed_Click_1(object sender, EventArgs e)
        {
            txtIO.ForeColor = Color.Red;
        }

        private void btnBlue_Click_1(object sender, EventArgs e)
        {
            txtIO.ForeColor = Color.Blue;
        }

        private void btnPink_Click_1(object sender, EventArgs e)
        {
            txtIO.ForeColor = Color.Pink;
        }

        private void btnBlack_Click_1(object sender, EventArgs e)
        {
            txtIO.ForeColor = Color.Black;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRed_Click_1(null, null);
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRed_Click(null, null);
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtIO.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtIO.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtIO.ForeColor = Color.Black;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtIO.ForeColor = Color.Pink;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
