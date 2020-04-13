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

            double c = 1.0;
            double v = 0.33;
            double sumCV = 1.33;

            Console.WriteLine((c + v) == sumCV);
        }
    }
}
