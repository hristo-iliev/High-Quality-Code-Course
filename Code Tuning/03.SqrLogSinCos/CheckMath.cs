//// Write a program to compare the performance of square root, natural logarithm,
//// sinus for float, double and decimal values.

namespace _03.SqrLogSinCos
{
    using System;
    using System.Diagnostics;

    public class CheckMath
    {
        public static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void Main()
        {
            string str = new string('a', 5000000);

            Console.Write("square root:\t");
            DisplayExecutionTime(() =>
            {
                double result = Math.Sqrt(2345);
            });

            Console.Write("logarithm:\t");
            DisplayExecutionTime(() =>
            {
                double result = Math.Log10(2345);
            });

            Console.Write("sin float:\t");
            DisplayExecutionTime(() =>
            {
                float result = (float)Math.Sin(2345);
            });

            Console.Write("sin double:\t");
            DisplayExecutionTime(() =>
            {
                double result = Math.Sin(2345);
            });

            Console.Write("sin decimal:\t");
            DisplayExecutionTime(() =>
            {
                decimal result = (decimal)Math.Sin(2345);
            });
        }
    }
}
