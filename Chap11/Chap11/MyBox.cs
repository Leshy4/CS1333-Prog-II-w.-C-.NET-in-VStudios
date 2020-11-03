using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11
{
    class MyBox
    {
        public MyBox(int L, int W)
        {
           L  = Length;
           W =  Width;
        }

        public virtual string nameIt()
        {
            return "2d boxes";
        }


    }
}
