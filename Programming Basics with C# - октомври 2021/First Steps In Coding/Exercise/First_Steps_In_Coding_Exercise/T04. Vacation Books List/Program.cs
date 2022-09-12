using System;

namespace T04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesPerBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int readedPagesPerHour = (pagesPerBook / pagesPerHour);
            int pagesPerDay = readedPagesPerHour / days;

            Console.WriteLine(pagesPerDay);
        }
    }
}
