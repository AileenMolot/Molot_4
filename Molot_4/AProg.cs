using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molot_4
{
    class AProg
    {
        private int a1;
        private int d;
        public int n;

        public int Number
        {
            get
            {
                return this.n;
            }
            set
            {
                this.n = value;
            }
        }

        public AProg(int a1, int d, int n = 0)
        {
            this.a1 = a1;
            this.d = d;
            this.n = n;
        }

        public int GetLast()
        {
            int last = this.a1 + (this.n - 1) * this.d;
            return last;
        }

        public int GetSum()
        {
            int sum = CalcSum(this.a1, this.d, this.n);
            return sum;
        }

        private int CalcSum(int a, int d, int n)
        {
            n--;
            if (n > 0)
                return CalcSum(a + d, d, n) + a;
            else
                return a;
        }

        public int GetAverage()
        {
            int average = CalcSum(this.a1, this.d, this.n) / this.n;
            return average;
        }
    }
}
