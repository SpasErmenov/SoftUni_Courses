using System;

namespace T09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kvMetri = double.Parse(Console.ReadLine());

            double cenaNaKvMetar = 7.61;

            double cena = kvMetri * cenaNaKvMetar;

            double discount = cena * 0.18;
            double finalPrice = cena - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
