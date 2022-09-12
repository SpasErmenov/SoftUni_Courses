using System;

namespace T02._Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double degree = r * 180 / Math.PI;

            Console.WriteLine(degree);
        }
    }
}
