using System;

namespace T04._Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enterPassword = Console.ReadLine();
            const string correctPassword = "s3cr3t!P@ssw0rd";

            if (enterPassword == correctPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
