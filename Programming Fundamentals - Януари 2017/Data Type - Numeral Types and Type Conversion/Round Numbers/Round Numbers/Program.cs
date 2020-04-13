using System;

namespace Round_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2.5455;
            Console.WriteLine(Math.Round(a));
            Console.WriteLine(Math.Round(a,2));
            Console.WriteLine(Math.Ceiling(a));
            Console.WriteLine(Math.Floor(a));
        }
    }
}
