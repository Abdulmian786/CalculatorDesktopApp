using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp1
{
    public partial class Form1 : Form
    {
        double firstNum;
        double secNum;
        string oper;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text += "0";
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text += "9";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            string f = Convert.ToString(firstNum);
            string s = Convert.ToString(secNum);
            f = "";
            s = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnSqu_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {

            }
            else
            {
                double temp = double.Parse(txtDisplay.Text);
                txtDisplay.Text = (temp * temp).ToString();
            }
           
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {

            }
            else
            {
                double temp = double.Parse(txtDisplay.Text);
                txtDisplay.Text = (temp * -1).ToString();
            }
            

            
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            oper = "+";
            txtDisplay.Text = "";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            oper = "-";
            txtDisplay.Text = "";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            oper = "*";
            txtDisplay.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            oper = "/";
            txtDisplay.Text = "";
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            secNum = double.Parse(txtDisplay.Text);

            switch (oper)
            {
                case "+":
                    txtDisplay.Text = (firstNum + secNum).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (firstNum - secNum).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (firstNum * secNum).ToString();
                    break;
                case "/":
                    if (secNum == 0)
                    {
                        txtDisplay.Text = "Error";
                    }
                    else
                    {
                        txtDisplay.Text = (firstNum / secNum).ToString();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("."))
            {

            }
            else
            {
                txtDisplay.Text += ".";
            }

        }
    }
}
