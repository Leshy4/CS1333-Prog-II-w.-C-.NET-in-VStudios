using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        double size = 0;
        double crust = 0;
        double toppings = 0;
        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formAppearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ColorDialog.Equals = this.ForeColor;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double pepper = 0.1;
            pepper += toppings;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            double chicken = 0.2;
            chicken += toppings;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            double bacon = 0.1;
            bacon += toppings;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            double olive = .15;
            olive += toppings;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            double onion = .05;
            onion += toppings;
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            double bitSize = 7;
            bitSize += size;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            double byteSize = 8;
            byteSize += size;
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            double mBsize = 10;
            mBsize += size;        
            
        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double thin = 3;
            thin += crust;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double deepDish = 6;
            deepDish += crust;

        }


        

        private void textAppearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ColorDialog = this.Text;
        }

        public double myPizza()
        {
            double area = (size * 3.14);
            double total = (crust + toppings);
            return area + total;
            
        }

        

        private void button1_Click(object sender, EventArgs e, double area, double total)
        {
          MessageBox.Show("Your pizza is " + area + " square inches" + "\nYour pizza crust cost is $" + crust + "\nYour toppings cost is $" + toppings + "\nYour Total is $" + total);

        }

    }
}
