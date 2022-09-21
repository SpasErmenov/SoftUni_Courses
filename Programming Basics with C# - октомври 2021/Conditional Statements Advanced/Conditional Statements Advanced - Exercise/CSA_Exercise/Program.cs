using System;

namespace CSA_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int s = r * c;
            double totalPrice = 0;

            switch (type)
            {
                case "Premiere":
                    totalPrice = s * 12;
                    Console.WriteLine($"{totalPrice:F2} leva");
                    break;
                case "Normal":
                    totalPrice = s * 7.5;
                    Console.WriteLine($"{totalPrice:F2} leva");
                    break;
                case "Discount":
                    totalPrice = s * 5;
                    Console.WriteLine($"{totalPrice:F2} leva");
                    break;

                default:
                    break;
            }
        }
    }
}
