using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                T3.Text = Convert.ToString(int.Parse(T1.Text) / int.Parse(T2.Text));
            }
            catch(ArithmeticException b)
            {
                MessageBox.Show(b.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] NameIt = new string[4];
                NameIt[0] = "Tom";
                NameIt[1] = "Bill";
                NameIt[2] = "Mel";
                NameIt[3] = "Jill";
                T3.Text = NameIt[int.Parse(T1.Text)];
            }
            catch(IndexOutOfRangeException Ohex)
            {
                //usually show a message like Please Check The Number Of The Array or something like that
                MessageBox.Show(Ohex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                T3.Text = Convert.ToString(int.Parse(T1.Text) / int.Parse(T2.Text));
            }
            catch (ArithmeticException b)
            {
                MessageBox.Show(b.Message);
            }
            catch (FormatException Fex)
            {
                MessageBox.Show(Fex.Message);
            }
            //the Catch-All
            catch (Exception anyEx)
            {
                MessageBox.Show(anyEx.Message);
            }


        }
    }
}
