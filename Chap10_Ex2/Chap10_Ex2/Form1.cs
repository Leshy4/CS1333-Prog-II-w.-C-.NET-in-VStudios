using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap10_Ex2
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           comboBox1.SelectedItem = label1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            textBox1.Text = label1.Text;
        }
    }
}
