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
            int[] arr = new int[6] { 1,2,3,4,5,6};
            for (int i = 0;i<arr.Length;i++)
            {
                arr[i] = i;
                Console.WriteLine(arr[i]);
            }
            foreach(int j in arr)
            {
                Console.WriteLine("using foreach loop : " + j);
               
            }
            arr.Max();
        }
    }
}