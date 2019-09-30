using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsEven(3));
        }
        static bool IsEven(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }
    }
}
