using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int addedSumOfInts = AddTwoNumbers(9, 16);
            Console.WriteLine("Int: " + addedSumOfInts);
            double addedSumOfDoubles = AddTwoNumbers(7.5, 13.8);

            Console.WriteLine("Double: " + addedSumOfDoubles);
        }

        static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        static double AddTwoNumbers(double x, double y)
        {
            return x + y;
        }
    }
}
