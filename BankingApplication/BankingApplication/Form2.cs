using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{   
    public partial class Form2 : Form
    {
        customer c1;
        public Form2(customer c)
        {
            InitializeComponent();
            c1 = c;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(c1.pwd))
            {
                if (textBox2.Text.Equals(textBox3.Text))
                {
                    c1.pwd = textBox2.Text;
                    MessageBox.Show("password changed successfully");
                }
                else
                {
                    MessageBox.Show("new passwords does not match. type it again");
                    textBox3.Text = string.Empty;
                }
            }
            else
            {
                textBox1.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox2.Text = string.Empty;
                MessageBox.Show("wrong password entered");
            }
        }
    }
}
