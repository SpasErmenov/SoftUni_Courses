using System;

namespace T08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodDogs = int.Parse(Console.ReadLine());
            int foodCats = int.Parse(Console.ReadLine());

            double priceD = foodDogs * 2.5;
            int priceC = foodCats * 4;

            double total = priceD + priceC;

            Console.WriteLine($"{total} lv.");
        }
    }
}
