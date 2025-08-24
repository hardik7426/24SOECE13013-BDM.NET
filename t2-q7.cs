using System;
namespace BD_MAM
{
    class NumberManipulator
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x; 
            x = y; 
            y = temp; 
        }
    }
    internal class t2_q7
    {
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            /* local variable definition */
            int a = 50;
            int b = 100;
            Console.WriteLine("Before swap value of a : {0}", a);
            Console.WriteLine("Before swap value of b : {0}", b);

            /* calling a function to swap the values */
            n.swap(ref a, ref b);
            Console.WriteLine("After swap value of a : {0}", a);
            Console.WriteLine("After swap value of b : {0}", b);
            Console.ReadLine();
        }
    }
}