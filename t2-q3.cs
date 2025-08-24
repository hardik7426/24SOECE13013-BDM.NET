using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BD_MAM
{
    internal class t2_q3
    {
        static void Main(string[] args)
        {
            string firstName = "Alexa";
            string lastName = "kong";
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Please enter your new first name:");
            firstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("New name: " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}