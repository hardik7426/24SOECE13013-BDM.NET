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
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter gender (M/F): ");
            char gender = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (gender == 'M')
                Console.WriteLine("Mr. " + name);
            else if (gender == 'F')
                Console.WriteLine("Ms. " + name);
            else
                Console.WriteLine("Invalid gender");
        }
    }
}
