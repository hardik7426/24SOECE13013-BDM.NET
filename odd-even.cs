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
            Console.Write("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an Even number");
            }
            else
            {
                Console.WriteLine($"{number} is an Odd number");
            }
                Console.Read();
        }
    }
}
