namespace _02_ContidionalStatements
{
    using System;

    public class SearchForValue
    {
        public static void Main(string[] args)
        {
            const int ExpectedValue = 666;

            int[] numbers = { 2, 3, 4, 56, 6 };
            bool valueFound = false;
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {                    
                    if (numbers[i] == ExpectedValue)
                    {
                        valueFound = true;
                    }                    
                }
                
                Console.WriteLine(numbers[i]);
            }

            // More code here
            if (valueFound)
            {
                Console.WriteLine("Value Found");
            }
            else
            {
                Console.WriteLine("Value is not Found");
            }
        }
    }
}
