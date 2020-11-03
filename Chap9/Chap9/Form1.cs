using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "My Grade Form";
            average.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Do you really want to exit!");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void assignment1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            assignment1.Clear();
            assignment2.Clear();
            assignment3.Clear();
            numOfGrades.Clear();
            answer.Clear();
            button2.Enabled = false;
        }

        private void average_Click(object sender, EventArgs e)
        {
            int A1, A2, A3, N1;
            double avg;

            A1 = int.Parse(assignment1.Text);
            A2 = int.Parse(assignment2.Text);
            A3 = int.Parse(assignment3.Text);
            N1 = int.Parse(numOfGrades.Text);

            avg = (A1 + A2 + A3) / N1;
            avg = avg / 100;
            answer.Text = string.Format("{0:P}", avg).ToString();
        }

    }
}
