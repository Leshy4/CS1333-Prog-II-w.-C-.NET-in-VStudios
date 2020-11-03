using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap10_Ex5
{
    public partial class Form1 : Form
    {
        int balance = 1500;
        string signUpSheet = "";
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
       

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e, int c)
        {
           
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            balance = 35 + balance;
            textBox2.Text = "Total Charges = $" + balance;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            balance = 200 + balance;
            textBox2.Text = "Total Charges = $" + balance;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            balance = 50 + balance;
            textBox2.Text = "Total Charges = $" + balance;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            balance = 45 + balance;
            textBox2.Text = "Total Charges = $" + balance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You " + textBox1.Text + ".  Your Balance is = $" + balance);
            signUpSheet += textBox1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            balance = 1500;
            textBox2.Text = "Total Charge = $" + balance;
        }
                    
    }
}
