﻿using System;

namespace While_Loop___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            string input = Console.ReadLine();
            int sum = 0;

            bool bookFound = false;

            while (input != "No More Books")
            {
                sum += 1;

                if (input == bookName)
                {
                    Console.WriteLine($"You checked {sum - 1} books and found it.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {sum} books.");
            }
        }
    }
}
