using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Calculation
    {
        private int n;
        public Calculation(int n)
        {
            this.n = n;
        }
        public int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Nhập số nguyên dương");
            if (n == 0 || n == 1)
                return 1;
            return n * Factorial(n - 1);
        }
    }
}

