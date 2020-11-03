using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap9_Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) ;
           textBox1.Text = "Answer = " + sum;
           textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int product = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            textBox1.Text = "Answer = " + product;
            textBox2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
