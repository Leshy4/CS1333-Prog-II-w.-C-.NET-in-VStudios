using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrayStuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myString = "this is the text";

            textBox1.Text = myString;

             //finds every character in the word
            char[] chunkyString = myString.ToCharArray();
           
            for (int j = 0; j < chunkyString.Length; j++)
            {
                textBox2.Text += chunkyString[j].ToString();
            }
          
            for (int j = 0; j < chunkyString.Length; j++)
            {
                if (chunkyString[j] == 't')
                {
                    chunkyString[j] = 'X';
                }
                textBox3.Text += chunkyString[j].ToString();
            }


            for (int j = 0; j < chunkyString.Length; j++)
            {
                int myAscii = (int)chunkyString[0];
               
                textBox4.Text += myAscii+ 3 + "  " + myAscii;

                char originalLetter = (char)myAscii;
                int bla = myAscii + 3;
                char newLetter = (char)bla;
                textBox5.Text = originalLetter + "  " + newLetter;
                
            }
            // NOTES FOR THE FINAL EXAMINATIONS FOR PROGRAMMING II !!!!!!!!!!!!!!!!!!!!

            //Convert all the chars at once
            //richTextBox1.Text = new string(chunkyString);

            //richTextBox1.SelectionAlignment = HorizontalAlignment.Left;


        }



       

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            //THESE ARE TEXTS TOOLS
            //richTextBox1.Undo();
            //richTextBox1.Redo();
            //richTextBox1.SaveFile();
            
            //richTextBox1.LoadFile();

            //richTextBox1.Find();
            // SOMETHING LIKE THAT
            // richTextBox1.SelectedText.Replace(Clipboard.GetText);
            
        }


    }
}
