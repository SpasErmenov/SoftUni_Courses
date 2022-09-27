using System;

namespace T02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string input = "a";

            while (input != password)
            {
                input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"Welcome {username}!");
                }
            }
        }
    }
}
