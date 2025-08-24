using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_MAM
{
    internal class p1
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 4, 6, 8, 9, 10 };
            a.Max();
            a.Min();

            Console.WriteLine("Max Element is:" + a.Max());
            Console.WriteLine("Min Element is:" + a.Min());
            Console.WriteLine("Reverse array:" + a.Reverse());
        }

    }
}