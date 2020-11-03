using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11
{
    class Box3D: MyBox
    {
        private int _height;
        private int _volume;

        public Box3D(int H)
        {
            _height = H;
        }

        public Box3D(int L, int W, int H)
            :base(L,W)
        {
            _height = H;
        }

        
        public int Height
        {
            get {return _height;}
            set { _height = value;} 
        }

        public override string nameIt()
        {
            base.nameIt();
            return "these are 3d boxes";
        }



        public int Volume()
        {
            _volume = myBoxArea() * Height;
            return _volume;
        }


        

    }
}
