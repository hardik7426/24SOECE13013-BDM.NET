﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BD_MAM
{
    internal class t2_q2
    {
        static void Main(string[] args)
        {
            int a = 50;
            if (a < 20)
            {
                /* if condition is true then print the following */
                Console.WriteLine("a is less than 20");
            }
            else
            {
                /* if condition is false then print the following */
                Console.WriteLine("a is not less than 20");
            }
            Console.WriteLine("value of a is: {0}", a);
            Console.ReadLine();
        }
    }
}