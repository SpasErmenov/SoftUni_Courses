using System;

namespace T12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double s = double.Parse(Console.ReadLine());
            double price = 0;

            switch (town)
            {
                case "Sofia":
                    if (s >= 0 && s <= 500)
                    {
                        price = s * 0.05;
                        Console.WriteLine($"{price:F2}");
                    }
                    else if (s > 500 && s <= 1000)
                    {
                        price = s * 0.07;
                        Console.WriteLine($"{price:F2}");
                    }
                    else if (s > 1000 && s <= 10000)
                    {
                        price = s * 0.08;
                        Console.WriteLine($"{price:F2}");
                    }
                    else if (s > 10000)
                    {
                        price = s * 0.12;
                        Console.WriteLine($"{price:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;
                case "Varna":
                    if (s >= 0 && s <= 500)
                    {
                        price = s * 0.045;
                        Console.WriteLine($"{price:F2}");
                    }
                    else if (s > 500 && s <= 1000)
                    {
                        price = s * 0.075;
                        Console.WriteLine($"{price:F2}");
                    }
                    else if (s > 1000 && s <= 10000)
                    {
                        price = s * 0.1;
                        Console.WriteLine($"{price:F2}");
                    }
                    else if (s > 10000)
                    {
                        price = s * 0.13;
                        Console.WriteLine($"{price:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (s >= 0 && s <= 500)
                    {
                        price = s * 0.055;
                        Console.WriteLine($"{price:F2}");
                    }
                    else if (s > 500 && s <= 1000)
                    {
                        price = s * 0.08;
                        Console.WriteLine($"{price:F2}");
                    }
                    else if (s > 1000 && s <= 10000)
                    {
                        price = s * 0.12;
                        Console.WriteLine($"{price:F2}");
                    }
                    else if (s > 10000)
                    {
                        price = s * 0.145;
                        Console.WriteLine($"{price:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
