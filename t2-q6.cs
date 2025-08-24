using System;
namespace BD_MAM
{
    internal class t2_q6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World ?");
            Console.WriteLine("You entered the following {0} command line arguments:",
            args.Length);

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}