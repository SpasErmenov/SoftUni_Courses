using System;

namespace T05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double n = double.Parse(Console.ReadLine());
            double price = 0;

            if (product == "coffee")
            {
                if (city == "Sofia")
                {
                    price = 0.5 * n;
                    Console.WriteLine(price);
                }
                else if (city == "Plovdiv")
                {
                    price = 0.4 * n;
                    Console.WriteLine(price);
                }
                else
                {
                    price = 0.45 * n;
                    Console.WriteLine(price);
                }
            }
            else if (product == "water")
            {
                if (city == "Sofia")
                {
                    price = 0.8 * n;
                    Console.WriteLine(price);
                }
                else if (city == "Plovdiv")
                {
                    price = 0.7 * n;
                    Console.WriteLine(price);
                }
                else
                {
                    price = 0.7 * n;
                    Console.WriteLine(price);
                }

            }
            else if (product == "beer")
            {
                if (city == "Sofia")
                {
                    price = 1.2 * n;
                    Console.WriteLine(price);
                }
                else if (city == "Plovdiv")
                {
                    price = 1.15 * n;
                    Console.WriteLine(price);
                }
                else
                {
                    price = 1.1 * n;
                    Console.WriteLine(price);
                }
            }
            else if (product == "sweets")
            {
                if (city == "Sofia")
                {
                    price = 1.45 * n;
                    Console.WriteLine(price);
                }
                else if (city == "Plovdiv")
                {
                    price = 1.3 * n;
                    Console.WriteLine(price);
                }
                else
                {
                    price = 1.35 * n;
                    Console.WriteLine(price);
                }
            }
            else if (product == "peanuts")
            {
                if (city == "Sofia")
                {
                    price = 1.6 * n;
                    Console.WriteLine(price);
                }
                else if (city == "Plovdiv")
                {
                    price = 1.5 * n;
                    Console.WriteLine(price);
                }
                else
                {
                    price = 1.55 * n;
                    Console.WriteLine(price);
                }
            }
        }
    }
}
