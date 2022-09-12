using System;

namespace T01_USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());

            const double bgn = 1.79549;

            double formula = usd * bgn;

            Console.WriteLine(formula);
        }
    }
}
