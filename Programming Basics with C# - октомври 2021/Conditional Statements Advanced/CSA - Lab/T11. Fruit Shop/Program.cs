using System;

namespace T11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double n = double.Parse(Console.ReadLine());
            double price = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.5 * n;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "apple":
                        price = 1.2 * n;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "orange":
                        price = 0.85 * n;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "grapefruit":
                        price = 1.45 * n;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "kiwi":
                        price = 2.7 * n;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "pineapple":
                        price = 5.5 * n;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "grapes":
                        price = 3.85 * n;
                        Console.WriteLine($"{price:F2}");
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.7 * n;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "apple":
                        price = 1.25 * n;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "orange":
                        price = 0.9 * n;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "grapefruit":
                        price = 1.6 * n;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "kiwi":
                        price = 3 * n;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "pineapple":
                        price = 5.6 * n;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "grapes":
                        price = 4.2 * n;
                        Console.WriteLine($"{price:F2}");
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
