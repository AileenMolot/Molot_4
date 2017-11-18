using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molot_4
{
    class Square
    {
        private int sideLength;

        public int SideLength
        {
            get
            {
                return this.sideLength;
            }
            set
            {
                if (value > 0)
                    this.sideLength = value;
                else
                    this.sideLength = 0;
            }
        }

        public Square()
        {
            this.sideLength = 0;
        }

        public Square (int sideLength)
        {
            if (sideLength > 0)
                this.sideLength = sideLength;
            else
                this.sideLength = 0;
        }

        public int GetPerimeter ()
        {
            int perimeter = this.sideLength * 4;
            return perimeter;
        }

        public int GetArea ()
        {
            int area = this.sideLength * this.sideLength;
            return area;
        }
    }
}
