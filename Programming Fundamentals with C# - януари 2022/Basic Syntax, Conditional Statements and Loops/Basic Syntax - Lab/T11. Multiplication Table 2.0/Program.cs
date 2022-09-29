using System;

namespace T11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (y > 10)
            {
                Console.WriteLine($"{x} X {y} = {x * y}");
            }
            else
            {

                for (int i = y; i <= 10; i++)
                {
                    Console.WriteLine($"{x} X {i} = {x * i}");
                }
            }
        }
    }
}
