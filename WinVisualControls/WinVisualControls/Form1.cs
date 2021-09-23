using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinVisualControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            txtFirstParagraph.Text = dateTimePicker.Value.ToString();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtFirstParagraph.ForeColor = colorDialog1.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtFirstParagraph.Font = fontDialog1.Font;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNames.Text = cboNames.Text;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            txtNames.ForeColor = Color.Blue;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            txtNames.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            txtNames.ForeColor = Color.Green;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            txtNames.ForeColor = Color.Black;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            
            if(img1.ImageLocation == "C:\\Users\\Diogo\\source\\repos\\WinVisualControls\\WinVisualControls\\Pictures\\sly.jpg")
            {
                img1.ImageLocation = "C:\\Users\\Diogo\\source\\repos\\WinVisualControls\\WinVisualControls\\Pictures\\fiddle.png";
            }
            else
            {
                img1.ImageLocation = "C:\\Users\\Diogo\\source\\repos\\WinVisualControls\\WinVisualControls\\Pictures\\sly.jpg";
            }

        }
    }
}