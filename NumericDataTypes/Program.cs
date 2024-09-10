using System;

namespace NumericDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int age = 25, dept = -1000;
            int age = 25;
            int number = -1000;
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(age);
            Console.WriteLine(number);

            long bigNumber = 10000000L;
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(bigNumber);

            double negative = -569.8D;
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(negative);

            float precision = -40.0092227F;
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(precision);

            decimal money = 14.99M;
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(money);
        }
    }
}