using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(4));
        }
        static int Square(int n)
        {
            return n * n;
        }
    }
}
