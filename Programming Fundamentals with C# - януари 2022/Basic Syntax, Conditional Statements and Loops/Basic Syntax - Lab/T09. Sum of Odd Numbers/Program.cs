using System;

namespace T09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;


            for (int i = 0; i < n; i++)
            {
                int currentOdd = 1 + (i * 2);
                Console.WriteLine(currentOdd);
                sum += currentOdd;
            }
            Console.WriteLine($"Sum: " + sum);
        }
    }
}
