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
    public partial class Form5 : Form
    {
        customer c1;
        public Form5(customer c)
        {
            InitializeComponent();
            c1 = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long balance;
            long.TryParse(textBox2.Text, out balance);
            if (balance < c1.bal)
            {
                MessageBox.Show("transaction not possible. insufficient balance");
            }
            else
            {
                c1.bal -= balance;
                MessageBox.Show("Transaction Successful");
                
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox4.Text = c1.bal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form3 f3 = new Form3(c1);
            this.Close();
            //f3.Show();
            
        }
    }
}
