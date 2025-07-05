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
            int n, fact = 1; // Declaring integer variables 'n' for input number and 'fact' initialized to 1 for storing factorial

            Console.WriteLine("Enter Number : "); // Asking the user to enter a number

            string str = Console.ReadLine(); // Reading user input as string

            n = Convert.ToInt32(str); // Converting the input string to integer and storing in 'n'

            for (int i = 1; i <= n; i++) // Loop from 1 to 'n' to calculate factorial
            {
                fact = fact * i; // Multiply 'fact' by current value of 'i' to accumulate factorial
            }

            Console.WriteLine("Factorial : {0}", fact); // Print the factorial using placeholder syntax
            Console.Read();
        }
    }
}
