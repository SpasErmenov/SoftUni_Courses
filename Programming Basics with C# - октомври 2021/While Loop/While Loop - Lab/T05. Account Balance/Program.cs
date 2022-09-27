using System;

namespace T05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;

            while (input != "NoMoreMoney")
            {
                double x = double.Parse(input);

                if (x < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += x;
                Console.WriteLine($"Increase: {x:F2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
