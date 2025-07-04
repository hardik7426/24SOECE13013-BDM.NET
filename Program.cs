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
            Console.WriteLine("Enter the NO 1 : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the NO 2 :");
            int b=Convert.ToInt32(Console.ReadLine());
            int sum;
            sum = a + b;
            Console.WriteLine($"sum is {a} + {b} : "+sum);

            Console.Read();
        }
    }
}
