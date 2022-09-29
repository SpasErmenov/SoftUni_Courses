using System;

namespace T07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = 0;

            if (age >= 0 && age <= 18)
            {
                switch (dayType)
                {
                    case "Weekday":
                        ticketPrice = 12;
                        break;
                    case "Weekend":
                        ticketPrice = 15;
                        break;
                    case "Holiday":
                        ticketPrice = 5;
                        break;

                    default:
                        break;
                }
                Console.WriteLine($"{ticketPrice}$");
            }
            else if (age > 18 && age <= 64)
            {
                switch (dayType)
                {
                    case "Weekday":
                        ticketPrice = 18;
                        break;
                    case "Weekend":
                        ticketPrice = 20;
                        break;
                    case "Holiday":
                        ticketPrice = 12;
                        break;

                    default:
                        break;
                }
                Console.WriteLine($"{ticketPrice}$");
            }
            else if (age > 64 && age <= 122)
            {
                switch (dayType)
                {
                    case "Weekday":
                        ticketPrice = 12;
                        break;
                    case "Weekend":
                        ticketPrice = 15;
                        break;
                    case "Holiday":
                        ticketPrice = 10;
                        break;

                    default:
                        break;
                }
                Console.WriteLine($"{ticketPrice}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
