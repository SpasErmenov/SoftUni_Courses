using System;

namespace T08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggestN = int.MinValue;
            int smallestN = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a > biggestN)
                {
                    biggestN = a;
                }
                if (a < smallestN)
                {
                    smallestN = a;
                }
            }
            Console.WriteLine($"Max number: {biggestN}");
            Console.WriteLine($"Min number: {smallestN}");
        }
    }
}
