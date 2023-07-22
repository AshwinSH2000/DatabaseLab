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
    
    public partial class Form1 : Form
    {
        customer c1 = new customer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(c1);
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //signin click
            if (textBox1.Text.Equals(c1.uid) && textBox2.Text.Equals(c1.pwd))
            {
                MessageBox.Show("login successful");
                Form3 f3 = new Form3(c1);
                f3.Show();
            }
            else
            {
                MessageBox.Show("login failed");
                textBox2.Text = string.Empty;
            }
        }
    }
}
