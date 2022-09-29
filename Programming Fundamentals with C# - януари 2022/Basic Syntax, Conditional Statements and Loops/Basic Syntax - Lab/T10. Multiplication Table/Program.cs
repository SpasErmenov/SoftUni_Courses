using System;

namespace T10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{x} X {i} = {x * i}");
            }
        }
    }
}
