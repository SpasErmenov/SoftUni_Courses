using System;

namespace T10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int chetni = 0;
            int neChetni = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    chetni = chetni + a;
                }
                else
                {
                    neChetni = neChetni + a;
                }

            }

            if (chetni == neChetni)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = " + chetni);
            }
            else
            {
                int diff = Math.Abs(chetni - neChetni);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = " + diff);
            }
        }
    }
}
