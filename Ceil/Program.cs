using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ceil(3%10%10));
        }
        static int Ceil(float x)
        {
            int n = (int)x;
            if((n-x)<=0.5)
                n=n+1;
            return n;

            //int d = (int)(x + 0.5);
            //return d;
        }
    }
}
