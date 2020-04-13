using System;

namespace FloatPrecision
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0F;
            double b = 0.33F;
            double sum = 1.33F;

            Console.WriteLine((a+b) == sum);
        }
    }
}
