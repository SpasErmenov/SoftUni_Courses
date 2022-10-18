using System;

namespace Arrays___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine(weekDays[0]);
                    break;
                case 2:
                    Console.WriteLine(weekDays[1]);
                    break;
                case 3:
                    Console.WriteLine(weekDays[2]);
                    break;
                case 4:
                    Console.WriteLine(weekDays[3]);
                    break;
                case 5:
                    Console.WriteLine(weekDays[4]);
                    break;
                case 6:
                    Console.WriteLine(weekDays[5]);
                    break;
                case 7:
                    Console.WriteLine(weekDays[6]);
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }
        }
    }
}
