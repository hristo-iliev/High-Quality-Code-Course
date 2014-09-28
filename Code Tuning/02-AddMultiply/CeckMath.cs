namespace _02_AddMultiply
{
    using System;
    using System.Diagnostics;

    public class CeckMath
    {
        //// Write a program to compare the performance of add, subtract, increment, multiply,
        //// divide for int, long, float, double and decimal values.

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

            Console.WriteLine("ADD\t");
            Console.Write("int:\t");
            DisplayExecutionTime(() =>
            {
                int resultInt = 50 + 50 + 50;
            });

            Console.Write("long:\t");
            DisplayExecutionTime(() =>
            {
                long resultLong = 50 + 50 + 50;
            });

            Console.Write("float:\t");
            DisplayExecutionTime(() =>
            {
                float resultFloat = 50.5f + 50.5f + 50.5f;
            });

            Console.Write("double:\t");
            DisplayExecutionTime(() =>
            {
                double resultDouble = 50.5 + 50.5 + 50.5;
            });

            Console.Write("dcml:\t");
            DisplayExecutionTime(() =>
            {
                decimal resultDecimal = 50.5m + 50.5m + 50.5m;
            });
            
            Console.WriteLine();

            Console.WriteLine("SUBTRACT\t");
            Console.Write("int:\t");
            DisplayExecutionTime(() =>
            {
                int resultInt = 50 - 50 - 50;
            });

            Console.Write("float:\t");
            DisplayExecutionTime(() =>
            {
                float resultFloat = 50.5f - 50.5f - 50.5f;
            });

            Console.Write("long:\t");
            DisplayExecutionTime(() =>
            {
                long resultLong = 50 - 50 - 50;
            });

            Console.Write("double:\t");
            DisplayExecutionTime(() =>
            {
                double resultDouble = 50.5 - 50.5 - 50.5;
            });

            Console.Write("dcml:\t");
            DisplayExecutionTime(() =>
            {
                decimal resultDecimal = 50.5m - 50.5m - 50.5m;
            });

            Console.WriteLine();

            Console.WriteLine("INCREMENT\t");
            Console.Write("int:\t");
            DisplayExecutionTime(() =>
            {
                int resultInt = 0;
                resultInt++;
                resultInt++;
                resultInt++;
                resultInt++;
                resultInt++;
            });

            Console.Write("float:\t");
            DisplayExecutionTime(() =>
            {
                float resultFloat = 0f;
                resultFloat++;
                resultFloat++;
                resultFloat++;
                resultFloat++;
                resultFloat++;
            });

            Console.Write("long:\t");
            DisplayExecutionTime(() =>
            {
                long resultLong = 0;
                resultLong++;
                resultLong++;
                resultLong++;
                resultLong++;
                resultLong++;
            });

            Console.Write("double:\t");
            DisplayExecutionTime(() =>
            {
                double resultDouble = 0;
                resultDouble++;
                resultDouble++;
                resultDouble++;
                resultDouble++;
                resultDouble++;
            });

            Console.Write("dcml:\t");
            DisplayExecutionTime(() =>
            {
                decimal resultDecimal = 0m;
                resultDecimal++;
                resultDecimal++;
                resultDecimal++;
                resultDecimal++;
                resultDecimal++;
            });

            Console.WriteLine();

            Console.WriteLine("MULTIPLY\t");
            Console.Write("int:\t");
            DisplayExecutionTime(() =>
            {
                int resultInt = 50 * 50 * 50;
            });

            Console.Write("long:\t");
            DisplayExecutionTime(() =>
            {
                long resultLong = 50 * 50 * 50;
            });

            Console.Write("float:\t");
            DisplayExecutionTime(() =>
            {
                float resultFloat = 50.5f * 50.5f * 50.5f;
            });

            Console.Write("double:\t");
            DisplayExecutionTime(() =>
            {
                double resultDouble = 50.5 * 50.5 * 50.5;
            });

            Console.Write("dcml:\t");
            DisplayExecutionTime(() =>
            {
                decimal resultDecimal = 50.5m * 50.5m * 50.5m;
            });

            Console.WriteLine();

            Console.WriteLine("DiVIDE\t");
            Console.Write("int:\t");
            DisplayExecutionTime(() =>
            {
                int resultInt = 50 / 50 / 50;
            });

            Console.Write("long:\t");
            DisplayExecutionTime(() =>
            {
                long resultLong = 50 / 50 / 50;
            });

            Console.Write("float:\t");
            DisplayExecutionTime(() =>
            {
                float resultFloat = 50.5f / 50.5f / 50.5f;
            });

            Console.Write("double:\t");
            DisplayExecutionTime(() =>
            {
                double resultDouble = 50.5 / 50.5 / 50.5;
            });

            Console.Write("dcml:\t");
            DisplayExecutionTime(() =>
            {
                decimal resultDecimal = 50.5m / 50.5m / 50.5m;
            });
        }
    }
}
