using System;

namespace T04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            const double cm = 2.54;

            double result = inch * cm;
            Console.WriteLine(result);
        }
    }
}
