using System;

namespace T03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool value = true;

            int x = int.Parse(Console.ReadLine());

            int sum = 0;

            while (value == true)
            {
                int y = int.Parse(Console.ReadLine());

                sum = sum + y;

                if (sum >= x)
                {
                    Console.WriteLine(sum);
                    value = false;
                }


            }
        }
    }
}
