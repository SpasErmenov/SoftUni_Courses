using System;

namespace T07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string form = Console.ReadLine();
            double S = 0;

            if (form == "square")
            {
                double a = double.Parse(Console.ReadLine());
                S = a * a;
                Console.WriteLine(Math.Round(S, 3));
            }
            else if (form == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                S = a * b;
                Console.WriteLine(Math.Round(S, 3));
            }
            else if (form == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                S = Math.PI * (r * r);
                Console.WriteLine(Math.Round(S, 3));
            }
            else if (form == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                S = (a / 2) * h;
                Console.WriteLine(Math.Round(S, 3));

            }
        }
    }
}
