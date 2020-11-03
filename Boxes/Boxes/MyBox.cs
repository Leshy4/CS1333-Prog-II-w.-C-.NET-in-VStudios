using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    public class MyBox
    {        
            private int _length;
            private int _width;

            public MyBox()
            {
                _length = 9;
                _width = 7;
            }
            public MyBox(int L, int W)
            {
                _length = L;
                _width = W;        

            }


            public int Length
            {
                get { return _length; }
                set { _length = value; }
            }
            public int Width
            {
                get { return _width; }
                set { _width= value; }
            }




            public string myBoxArea()
            {
                return (_length * _width).ToString();
            }        
    }
}
