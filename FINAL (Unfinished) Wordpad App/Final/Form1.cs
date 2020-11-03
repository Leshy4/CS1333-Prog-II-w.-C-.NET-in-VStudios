using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing.Design;

namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //maybe not here but....
            //65-91 & 97-123
            //int x=(int)char[x];
            int encryption = 0;
            //if(x >= 97)(x<=122);
            //{
            //    encryption+= 122-(x-97);
            //    Convert.ToChar(encryption);

            //}


        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Find(textBox1.Text) ;
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //richTextBox1.SelectedText.Replace(richTextBox1.Text, textBox2.Text.ToCharArray());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.SaveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Size >= 3)
            {
                //richTextBox1.Font.Size - 2; 
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            //richTextBox1.SelectedText = FontStyle.Italic;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //richTextBox1.SelectedText = FontStyle.Bold;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //richTextBox1.Font.Size += 2;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveAsToolStripMenuItem_Click = System.Windows.Forms.SaveFileDialog();  
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
             //Form1_Load(OpenFileDialog, EventArgs e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Black;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int counter = 0;
            string blank = " ";
            
                richTextBox1.Find(blank);
                counter += 1;
                label2.Text = ("" + counter);

        }
    }
}
