using System;

namespace T12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid = true;
            while (isValid == true)
            {
                int number = int.Parse(Console.ReadLine());


                if (number < 0)
                {
                    number = number * (-1);
                }

                if (number % 2 == 1)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {number}");
                    isValid = false;
                }
            }
        }
    }
}
