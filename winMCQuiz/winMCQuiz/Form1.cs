using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winMCQuiz
{
    public partial class frmQuizz : Form
    {
        ///PASSWORD////////////////////////////
        string password = "diogo";          //
        //////////////////////////////////////
       
        
        const string FORMAT = "\r\n";
        int currentQuestionNumber = 0;
        int numberOfQuestions;
        ArrayList usrAnswers = new ArrayList();

        public frmQuizz()
        {
            InitializeComponent();

            loadQuestions.loadQ(); //read all questions
            numberOfQuestions = loadQuestions.questionArray.Count; //get number of questions

            txtNumber.Text = currentQuestionNumber+1 + " out of " + numberOfQuestions;
            string[] nullAnswers = new string[numberOfQuestions];
            usrAnswers.AddRange(nullAnswers);
        }

        private async void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(password))
            {
                txtPassword.BackColor = Color.DarkGreen;
                await Task.Delay(2*1000);
                txtPassword.Visible = false;
                txtPassword.Enabled = false;
                lblPassword.Visible = false;
                grpAnswer.Visible = true;
                txtAnswer.Visible = true;
                txtNumber.Visible = true;
                btnMark.Visible = true;
                btnPrevious.Visible = true;
                btnNext.Visible = true;
                this.BackColor = Color.LightBlue;
                menuStrip1.BackColor = Color.LightBlue;
                txtAnswer.BackColor = Color.LightYellow;
                txtAnswer.Text = displayAnswer(currentQuestionNumber);
            }
        }
        private static string displayAnswer(int qNum)
        {
            string output = "";

            Question q0 = (Question)loadQuestions.questionArray[qNum];
            output += q0.Prompt;

            for (int i = 0; i < 4; i++)
            {
                output += FORMAT + FORMAT + q0.Options[i];
            }

            return output;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuestionNumber < numberOfQuestions-1)
            {
                currentQuestionNumber += 1;
                txtAnswer.Text = displayAnswer(currentQuestionNumber);
                txtNumber.Text = currentQuestionNumber + 1 + " out of " + numberOfQuestions;
            }
            switch (usrAnswers[currentQuestionNumber])
            {
                case "A": radA.Checked = true; break;
                case "B": radB.Checked = true; ; break;
                case "C": radC.Checked = true; ; break;
                case "D": radD.Checked = true; ; break;
                default: radA.Checked = false;
                    radB.Checked = false;
                    radC.Checked = false;
                    radD.Checked = false; break;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(currentQuestionNumber > 0)
            {
                currentQuestionNumber -= 1;
                txtAnswer.Text = displayAnswer(currentQuestionNumber);
                txtNumber.Text = currentQuestionNumber + 1 + " out of " + numberOfQuestions;
            }
            switch (usrAnswers[currentQuestionNumber])
            {
                case "A": radA.Checked = true; break;
                case "B": radB.Checked = true; ; break;
                case "C": radC.Checked = true; ; break;
                case "D": radD.Checked = true; ; break;
                default:
                    radA.Checked = false;
                    radB.Checked = false;
                    radC.Checked = false;
                    radD.Checked = false; break;
            }
        }

        private void radA_Click(object sender, EventArgs e)
        {
            usrAnswers[currentQuestionNumber] = "A";
        }

        private void radB_Click(object sender, EventArgs e)
        {
            usrAnswers[currentQuestionNumber] = "B";
        }

        private void radC_Click(object sender, EventArgs e)
        {
            usrAnswers[currentQuestionNumber] = "C";
        }

        private void radD_Click(object sender, EventArgs e)
        {
            usrAnswers[currentQuestionNumber] = "D";
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            int grade = 0;
            for (int i = 0; i < numberOfQuestions; i++)
            {
                Question q0 = (Question)loadQuestions.questionArray[i];
                if (usrAnswers[i].Equals(q0.Answer[q0.Answer.Trim('\r').Length-1].ToString()))
                {
                    grade += 1;
                }
            }
            MessageBox.Show("Number of questions answered correctly is " + grade);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
