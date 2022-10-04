using System;

namespace T07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coin = Console.ReadLine();
            double sumOfCoins = 0;

            while (coin != "Start")
            {
                switch (coin)
                {
                    case "0.1":
                        sumOfCoins += double.Parse(coin);
                        break;
                    case "0.2":
                        sumOfCoins += double.Parse(coin);
                        break;
                    case "0.5":
                        sumOfCoins += double.Parse(coin);
                        break;
                    case "1":
                        sumOfCoins += double.Parse(coin);
                        break;
                    case "2":
                        sumOfCoins += double.Parse(coin);
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }
                coin = Console.ReadLine();
            }

            string product = Console.ReadLine();
            double productPrice = 0;

            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        productPrice = 2;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (sumOfCoins >= productPrice && sumOfCoins > 0 && productPrice > 0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    sumOfCoins -= productPrice;
                    productPrice = 0;
                }
                else if (productPrice > 0)
                {
                    Console.WriteLine($"Sorry, not enough money");
                    productPrice = 0;
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sumOfCoins:F2}");
        }
    }
}
