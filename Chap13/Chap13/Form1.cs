using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// pg. 776-777 class options of system.IO

namespace Chap13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creates a write file object
            TextWriter tw = new StreamWriter("e:Date.txt");

            tw.WriteLine(DateTime.Now);
            //it opens and it has to be closed
            tw.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextReader tr = new StreamReader("e:Date.txt");

            rt1.Text = tr.ReadLine();
            tr.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {//multi text writer
            string myText;           

            //reads old text from file before save
            TextReader mtr = new StreamReader("e:Date.txt");

            myText = mtr.ReadToEnd();
            myText = "This is new stuff \n" + myText;
            mtr.Close();

            //writes a new object in file
            TextWriter mtw = new StreamWriter("e:newDate.txt");
            mtw.WriteLine(myText);
            mtw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fName = tb1.Text;
            TextReader mtr = new StreamReader(fName);

            rt1.Text = mtr.ReadToEnd();
            mtr.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "e:";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text File|*.txt|Richtext File|*.rtf";

            //!= means not equal to
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string myFile = openFileDialog1.FileName;
                TextReader dtr = new StreamReader(myFile);
                rt1.Text = dtr.ReadToEnd();
                dtr.Close();
            }
            else { MessageBox.Show("you must enter a file name"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string mysavefile = saveFileDialog1.FileName;

                TextWriter dtw = new StreamWriter(mysavefile);
                dtw.WriteLine(rt1.Text);
                dtw.Close();
            }
            else { MessageBox.Show("What Are You Doing??"); }
        }

    }
}
