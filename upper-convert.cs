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
            string name, upperName;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            upperName = name.ToUpper();

            Console.WriteLine("OUTPUT: " + upperName);

            Console.ReadLine();
        }
    }
}
