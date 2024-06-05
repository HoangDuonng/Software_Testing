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
                // Nếu 'n' nhỏ hơn 0, ném ra một ngoại lệ với thông báo yêu cầu nhập số nguyên dương.
                throw new ArgumentException("Nhập số nguyên dương");
            if (n == 0 || n == 1)
                // Nếu 'n' bằng 0 hoặc 1, trả về 1 vì giai thừa của chúng là 1.
                return 1;
            // Sử dụng đệ quy để tính giai thừa: n! = n * (n-1)!
            return n * Factorial(n - 1);
        }
    }
}

