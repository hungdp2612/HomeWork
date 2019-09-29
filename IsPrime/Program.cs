using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(8));
        }
        static bool IsPrime(int n)
        {
            if(n <= 1)
                return false;
            for (int i = 2; i < n; i++) if (n % i == 0) 
            {
                return false;
            } 
            return true;
        }
    }
}
