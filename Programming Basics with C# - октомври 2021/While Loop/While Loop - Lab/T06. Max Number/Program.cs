using System;

namespace T06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double bigN = double.MinValue;

            while (input != "Stop")
            {
                double x = double.Parse(input);
                if (x > bigN)
                {
                    bigN = x;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(bigN);
        }
    }
}
