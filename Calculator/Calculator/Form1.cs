using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty; //to read the input when clicked 
        string Op1 = string.Empty; //First operand
        string Op2 = string.Empty; //Second operand 
        char Operator; //Operator
        double res = 0.0; //Final result
        int flag = 0;
        double num1 = 0;
        double num2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
            
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.calcdisp.Text = string.Empty;
            input = input + "0";
            this.calcdisp.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.calcdisp.Text = string.Empty;
            input = input + "2";
            this.calcdisp.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.calcdisp.Text = string.Empty;
            input = input + "1";
            this.calcdisp.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.calcdisp.Text = string.Empty;
            input = input + "3";
            this.calcdisp.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.calcdisp.Text = string.Empty;
            input = input + "4";
            this.calcdisp.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.calcdisp.Text = string.Empty;
            input = input + "5";
            this.calcdisp.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.calcdisp.Text = string.Empty;
            input = input + "6";
            this.calcdisp.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.calcdisp.Text = string.Empty;
            input = input + "7";
            this.calcdisp.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.calcdisp.Text = string.Empty;
            input = input + "8";
            this.calcdisp.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.calcdisp.Text = string.Empty;
            input = input + "9";
            this.calcdisp.Text += input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                flag = 1;
                this.calcdisp.Text = string.Empty;
                input = input + ".";
                this.calcdisp.Text += input;
            }
            else
            {
                ;
            }            
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '+';
            input = string.Empty;
            calcdisp.Text = input;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '-';
            input = string.Empty;
            calcdisp.Text = input;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '/';
            input = string.Empty;
            calcdisp.Text = input;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '*';
            input = string.Empty;
            calcdisp.Text = input;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Op2 = input;
            double.TryParse(Op1, out num1);
            double.TryParse(Op2, out num2);
            if (Operator == '+')
                res = num1 + num2;
            else if (Operator == '-')
                res = num1 - num2;
            else if (Operator == '*')
                res = num1 * num2;
            else if (Operator == '/')
            {
                if (num2 == 0)
                    calcdisp.Text = "Divide by zero ERROR!";
                else
                    res = num1 / num2;
            }
            else if (Operator == '^')
                res = Math.Pow(num1, num2);

            calcdisp.Text = res.ToString();
            input = res.ToString();
        }

        private void allclr_Click(object sender, EventArgs e)
        {
            Op1 = string.Empty;
            Op2 = string.Empty;
            num1 = 0;
            num2 = 0;
            input = string.Empty;
            calcdisp.Text = input;
        }

        private void clr_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            calcdisp.Text = input;
        }

        private void calcdisp_TextChanged(object sender, EventArgs e)
        {

        }

        private void fact_Click(object sender, EventArgs e)
        {
            Op1 = input;
            int x=1;
            int.TryParse(Op1, out x);
            for(int i=x-1; i>1 ; i--)
                x*=i;
            res=x;
            input = string.Empty;
            calcdisp.Text = res.ToString();
        }

        private void pow_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '^';
            input = string.Empty;
            calcdisp.Text = input;
        }

        private void root_Click(object sender, EventArgs e)
        {
            Op1 = input;
            double.TryParse(Op1, out num1);
            res = Math.Sqrt(num1);
            input = string.Empty;
            calcdisp.Text = res.ToString();
        }

        private void log_Click(object sender, EventArgs e)
        {
            Op1 = input;
            double.TryParse(Op1, out num1);
            res = Math.Log10(num1);
            input = string.Empty;
            calcdisp.Text = input;
        }
       
    }
}
