using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] {1, 4, 6, 8, 9};
            Console.WriteLine(test.ToString());
        }



        public static int[] Multi(int [] arr, int count)
        {
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            return arr;
        }
    }
}
