﻿using System;

namespace T03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int depositPeriod = int.Parse(Console.ReadLine());
            double yearPercent = double.Parse(Console.ReadLine());

            double sum = deposit + depositPeriod * ((deposit * (yearPercent / 100)) / 12);

            Console.WriteLine(sum);
        }
    }
}
