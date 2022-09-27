using System;

namespace T07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double smallN = double.MaxValue;

            while (input != "Stop")
            {
                double x = double.Parse(input);
                if (x < smallN)
                {
                    smallN = x;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(smallN);
        }
    }
}
