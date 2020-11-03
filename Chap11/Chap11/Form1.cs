using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Boxes;

namespace Chap11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MyBox box1 = new MyBox();
            //MyBox box2 = new MyBox(5,6);
            //MyBox box3 = new MyBox();

            //box1.Length = 2;
            //box1.Width = 4;


            //MessageBox.Show(box1.myBoxArea());
            //MessageBox.Show(box2.myBoxArea());
            //MessageBox.Show(box3.myBoxArea());

            //Box3D myCube = new Box3D();
            //myCube.Height = int.Parse(textBox1.Text);
            //MessageBox.Show("The Volume = " + myCube.Volume().ToString());

            Box3D myCube2 = new Box3D(4);
            MessageBox.Show(myCube2.Volume().ToString());

            Box3D myBox1 = new Box3D(2,3,4);
            MessageBox.Show(myBox1.Volume().ToString());

        }
    }

   

}
