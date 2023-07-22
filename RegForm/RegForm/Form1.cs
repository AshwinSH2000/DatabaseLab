using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //this is of no use. came bymistake
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regno = "Registration Number: " + textBox1.Text;
            string name = "\nName: " + textBox2.Text;
            richTextBox1.Text = regno + name;
            string gender = string.Empty;
            if (radioButton1.Checked)
                gender = "\nGender: Male";
            else
                gender = "\nGender: Female";
            richTextBox1.Text = regno + name + gender;
            string dob = "\nDob: " + dateTimePicker1.Value;
            
            string sub = string.Empty;
            if (comboBox1.Text == "CS")
            {
                // sub= "OOP\nDSA\nCOA\nDSD\nCCNW";
                listBox1.Items.Clear();
                listBox1.Items.Add("OOP");
                listBox1.Items.Add("DSA");
                listBox1.Items.Add("COA");
                listBox1.Items.Add("DSD");
                listBox1.Items.Add("CCNW");
            }
            else if (comboBox1.Text == "IT" || comboBox1.Text == "CCE")
            {
                //sub = "OOP\nDS\nPDC\nDSM\nPDC";
                listBox1.Items.Clear();
                listBox1.Items.Add("OOP");
                listBox1.Items.Add("DS");
                listBox1.Items.Add("PDC");
                listBox1.Items.Add("DSM");           
            }
                
            else if (comboBox1.Text == "ECE")
                sub = "AEC\nDEC\nDSP\nEMW\nSS";
            else
                sub = "ASD\nDSD\nEMT\nEMW\nCOA";
            listBox1.Text = sub;
            listBox1.Items.Add("DSP");
           // listBox1.Items = sub;
            richTextBox1.Text = regno + name + gender + dob + "\nSubjects:\n" + sub;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
