﻿using System;

namespace DT_and_Var.___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            int sum = 0;

            sum = first + second;
            sum /= third;
            sum *= fourth;

            Console.WriteLine(sum);
        }
    }
}
