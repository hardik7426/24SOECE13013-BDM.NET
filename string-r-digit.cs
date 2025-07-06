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
            Console.Write("Enter mobile number: ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                string masked = mobile.Substring(0, mobile.Length - 5) + new string('X', 5);
                Console.WriteLine("Masked Number: " + masked);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
