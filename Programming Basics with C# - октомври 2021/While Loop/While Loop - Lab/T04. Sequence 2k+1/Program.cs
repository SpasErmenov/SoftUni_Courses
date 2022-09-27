using System;

namespace T04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int formula = 1;

            while (n >= formula)
            {
                Console.WriteLine(formula);
                formula = formula * 2 + 1;
            }
        }
    }
}
