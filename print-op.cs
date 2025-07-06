using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_MAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;
            Console.Write(a + " " + b + " ");
            while (true)
            {
                c = a + b;
                if (c > 55)
                    break;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
