using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int addedSumOfInts = AddTwoInt(9, 16);
            Console.WriteLine("Int: " + addedSumOfInts);
            double addedSumOfDoubles = AddTwoDoubles(7.5, 13.8);

            Console.WriteLine("Double: " + addedSumOfDoubles);
        }

        static int AddTwoInt(int x, int y)
        {
            return x + y;
        }

        static double AddTwoDoubles(double x, double y)
        {
            return x + y;
        }
    }
}
