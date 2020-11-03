using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiFormSelect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.Aquamarine;
            timer1.Enabled = false;
            Form2 myform = new Form2("this is a test");
            myform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {Form2 myform = new Form2(textBox1.Text);
         myform.Show();}

        private void selectTextForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {Form2 myform = new Form2(richTextBox1.SelectedText);
         myform.Show();}

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {richTextBox1.Copy();}

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {richTextBox1.Cut();}

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {richTextBox1.Paste();}

        private void highlightToolStripMenuItem_Click(object sender, EventArgs e)
        {richTextBox1.SelectionBackColor = Color.Yellow;}

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectedText != "")
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                }
            }
        }

    }
}
