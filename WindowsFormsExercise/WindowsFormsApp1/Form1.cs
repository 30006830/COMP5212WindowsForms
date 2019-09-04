using System;
using WindowsFormsExercise;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static int counter = 0;
        static string opp = "";
        Calculate c1 = new Calculate();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                c1.num1 += "0";
                Total.Text = c1.num1;
            }

            else if (counter == 1)
            {
                c1.num1 += "0";
                Total.Text = c1.num2;
            }
            counter++;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                c1.num1 += "1";
                Total.Text = c1.num1;
            } 
            else if (counter == 1)
            {
                c1.num2 += "1";
                Total.Text = c1.num2;
            }             
            //counter++;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                c1.num1 += "2";
                Total.Text = c1.num1;
            }   
            else if (counter == 1)
            {
                c1.num2 += "2";
                Total.Text = c1.num2;
            }              
            //counter++;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                c1.num1 += "3";
                Total.Text = c1.num1;
            }   
            else if (counter == 1)
            {
                c1.num2 += "3";
                Total.Text = c1.num2;
            }              
            //counter++;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                c1.num1 += "4";
                Total.Text = c1.num1;
            }
            else if (counter == 1)
            {
                c1.num2 += "4";
                Total.Text = c1.num2;
            }
            //counter++;
            
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                c1.num1 += "5";
                Total.Text = c1.num1;
            }
            else if (counter == 1)
            {
                c1.num2 += "5";
                Total.Text = c1.num2;
            }
            //counter++;
            
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                c1.num1 += "6";
                Total.Text = c1.num1;
            }   
            else if (counter == 1)
            {
                c1.num2 += "6";
                Total.Text = c1.num2;
            }
            //counter++;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                c1.num1 += "7";
                Total.Text = c1.num1;
            }
            else if (counter == 1)
            {
                c1.num2 += "7";
                Total.Text = c1.num2;
            }
            //counter++;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                c1.num1 += "8";
                Total.Text = c1.num1;
            }
            else if (counter == 1)
            {
                c1.num2 += "8";
                Total.Text = c1.num2;
            }
            //counter++;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                c1.num1 += "9";
                Total.Text = c1.num1;
            }
            else if (counter == 1)
            {
                c1.num2 += "9";
                Total.Text = c1.num2;
            }
            //counter++;
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            opp = ".";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            opp = "+";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            opp = "-";
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            opp = "*";
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            opp = "/";
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            switch (opp)
            {
                case "+":
                    Total.Text = c1.Addition().ToString();
                    break;
                case "-":
                    Total.Text = c1.Subtraction().ToString();
                    break;
                case "*":
                    Total.Text = c1.Multiplication().ToString();
                    break;
                case "/":
                    Total.Text = c1.Division().ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
