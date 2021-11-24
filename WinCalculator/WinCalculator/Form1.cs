using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalculator
{
    public partial class Form1 : Form
    {
        private string strNum1 = "0";
        private string strOp = "";
        Boolean hasOperator = false;
        Boolean isAns = false;

        private void updateNumber(string input)
        {
            if (lblResult.Text.Equals("0") || isAns == true || hasOperator)
            {
                isAns = false;
                lblResult.Text = input;
            }
            else
            {
                lblResult.Text += input;
            }

            hasOperator = false;
        }

        private void updateOperator(string input)
        {
            if (!hasOperator)
            {
                strNum1 = lblResult.Text;
                strOp = input;
                hasOperator = true;
                isAns = false;
            }
            else
            {
                strOp = input;
            }
        }

        private void getResult()
        {
            double intNum1 = 0;
            double intNum2 = 0;

            intNum1 = double.Parse(strNum1);
            intNum2 = double.Parse(lblResult.Text);


            switch (strOp)
            {
                case "/": lblResult.Text = Convert.ToString(intNum1 / intNum2); break;
                case "x": lblResult.Text = Convert.ToString(intNum1 * intNum2); break;
                case "+": lblResult.Text = Convert.ToString(intNum1 + intNum2); break;
                case "-": lblResult.Text = Convert.ToString(intNum1 - intNum2); break;
                case "":; break;
            }

            strNum1 = lblResult.Text;
            isAns = true;
            hasOperator = false;
            strOp = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            updateNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            updateNumber("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            updateNumber("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            updateNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            updateNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            updateNumber("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            updateNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            updateNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            updateNumber("9");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            if (lblResult.Equals("0"))
            {
                strNum1 = "0";
                strOp = "";
                hasOperator = false;
                isAns = false;
                double intNum1 = 0; 
                double intNum2 = 0;
            }
            else
            {
                lblResult.Text = "0";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            updateNumber("0");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

            updateOperator("/");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            updateOperator("x");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            updateOperator("-");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            updateOperator("+");
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                getResult();
            }
            catch
            {
                lblResult.Text = "Syntax Error";
                isAns = true;
            }
        }
    }
}
