using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;

namespace winHangMan
{
    public partial class Form1 : Form
    {

        HangMan HMO = new HangMan();

        public Form1()
        {
            InitializeComponent();
            txtGuess.MaxLength = 1;
            btnGuess.Enabled = false;
        }

        private void clearScreen()
        {
            lblLetters.Visible = false;
            lblLetters.Text = "";
            lblResult.Text = "";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblWord.Text = HMO.generateNewWord();
            lblLives.Text = HMO.getRemaininLives().ToString();
            btnGuess.Enabled = true;
            picMan.Image = Properties.Resources.start;
            clearScreen();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblLives.Text = "";
            lblWord.Text = "";
            btnGuess.Enabled = false;
            clearScreen();
            picMan.Image = Properties.Resources.start;

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            try
            {
                char guess = char.Parse(txtGuess.Text.ToUpper());
                txtGuess.Text = "";
                lblWord.Text = HMO.checkNewLetter(guess);
                lblLives.Text = HMO.getRemaininLives().ToString();
                switch (HMO.getRemaininLives())
                {
                    case 0: picMan.Image = Properties.Resources._6;break;
                    case 1: picMan.Image = Properties.Resources._5;break;
                    case 2: picMan.Image = Properties.Resources._4;break;
                    case 3: picMan.Image = Properties.Resources._3;break;
                    case 4: picMan.Image = Properties.Resources._2;break;
                    case 5: picMan.Image = Properties.Resources._1;break;
                    case 6: picMan.Image = Properties.Resources._0;break;
                    case 7: picMan.Image = Properties.Resources.start;break;


                }
                if (HMO.getLifeLoss())
                {
                    lblLetters.Visible = true;
                    lblLetters.Text += " " + guess + " ";
                }
                if (HMO.getRemaininLives() == 0)
                {
                    clearScreen();
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = "YOU LOST! The correct word was: " + HMO.getGeneratedWord();
                    btnGuess.Enabled = false;
                }
                if (HMO.getWordFound())
                {
                    clearScreen();
                    lblResult.ForeColor = Color.Green;
                    lblResult.Text = "YOU WIN!";
                    btnGuess.Enabled = false;
                }
            }
            catch
            {

            }
        }

        private void txtGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || e.KeyChar == (char)Keys.Enter;
            if (e.KeyChar == (char)Key.Enter)
            {
                MessageBox.Show("Enter pressed");
            }
        }
    }
}
