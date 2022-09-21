using System;

namespace T07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double petarBudged = double.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());

            double NPrice = N * 250;
            double MPrice = (0.35 * NPrice) * M;
            double PPrice = (0.1 * NPrice) * P;

            double finalPrice = NPrice + MPrice + PPrice;

            if (N > M)
            {
                finalPrice = finalPrice * 0.85;

                if (petarBudged >= finalPrice)
                {
                    double moneyLeft = petarBudged - finalPrice;
                    Console.WriteLine($"You have {moneyLeft:F2} leva left!");
                }
                else
                {
                    double moneyNeed = finalPrice - petarBudged;
                    Console.WriteLine($"Not enough money! You need {moneyNeed:F2} leva more!");
                }
            }
            else
            {
                if (petarBudged >= finalPrice)
                {
                    double moneyLeft = petarBudged - finalPrice;
                    Console.WriteLine($"You have {moneyLeft:F2} leva left!");
                }
                else
                {
                    double moneyNeed = finalPrice - petarBudged;
                    Console.WriteLine($"Not enough money! You need {moneyNeed:F2} leva more!");
                }
            }
        }
    }
}
