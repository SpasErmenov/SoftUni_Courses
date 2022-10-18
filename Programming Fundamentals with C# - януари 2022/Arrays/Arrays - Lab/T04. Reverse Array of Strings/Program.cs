using System;

namespace T04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine().Split();

            Array.Reverse(letters);
            Console.WriteLine(string.Join(" ", letters));
        }
    }
}
