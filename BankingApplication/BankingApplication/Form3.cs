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
    public partial class Form3 : Form
    {
        customer c1;
        public Form3(customer c)
        {
            InitializeComponent();
            c1 = c;
            textBox1.Text = c1.cname;
            textBox2.Text = c1.accno;
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(c1);
            f5.Show();
        }
    }
}
