using System;

namespace T08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();


            double sum = 0;
            int year = 0;
            int skusan = 0;

            while (year < 12)
            {
                year += 1;
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    sum += grade;
                }
                else
                {
                    skusan += 1;
                }

                if (skusan == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {year - 1} grade");
                    break;
                }

            }
            if (skusan < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {(sum / 12):F2}");
            }
        }
    }
}
