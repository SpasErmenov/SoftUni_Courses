using System;

namespace While_Loop___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string name = Console.ReadLine();


                if (name == "Stop")
                {
                    break;
                }
                Console.WriteLine(name);
            }
        }
    }
}
