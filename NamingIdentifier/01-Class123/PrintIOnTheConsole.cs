using System;

public class PrintOnTheConsole
{
    private const int MaxCount = 6;
    
    public void Print(bool value)
    {
        Console.WriteLine(value);
    }

    private static void Main()
    {
        PrintOnTheConsole something = new PrintOnTheConsole();
        something.Print(true);
    }   
}
