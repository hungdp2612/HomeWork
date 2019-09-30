using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Abs(6));
        }
        static int Abs(int n)
        {
            if (n < 0)
            {
                n = n * (-1);
            }
            return n;
        }
    }
}
