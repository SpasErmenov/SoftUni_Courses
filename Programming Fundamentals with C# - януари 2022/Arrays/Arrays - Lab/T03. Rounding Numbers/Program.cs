﻿using System;

namespace T03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rawInput = Console.ReadLine().Split();
            double[] items = new double[rawInput.Length];

            for (int i = 0; i < rawInput.Length; i++)
            {
                items[i] = double.Parse(rawInput[i]);
            }

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == -0)
                {
                    items[i] = 0;
                }
                Console.WriteLine($"{items[i]} => {Math.Round(items[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
