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
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();
            string result = "";

            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                    result += char.ToLower(ch);
                else if (char.IsLower(ch))
                    result += char.ToUpper(ch);
                else
                    result += ch;
            }

            Console.WriteLine("Toggle Case: " + result);
        }
    }
}
