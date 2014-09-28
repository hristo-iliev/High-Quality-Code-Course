using System;

public class Main
{
    public void PrintStatistics(double[] arr)
    {        
        var max = this.CalculateGreatestNumber(arr);
        var min = this.CalculateMinimalNumber(arr);
        var average = this.CalculateAverage(arr);

        Console.WriteLine("The greatest number: " + max);
        Console.WriteLine("The minimal number: " + min);
        Console.WriteLine("Average: " + average);        
    }

    private double CalculateAverage(double[] arr)
    {
        double sum = 0;
        int count = arr.Length;
        for (int i = 0; i < count; i++)
        {
            sum += arr[i];
        }

        return sum / count;
    }

    private double CalculateMinimalNumber(double[] arr)
    {        
        double min = 0;
        int count = arr.Length;
        for (int i = 0; i < count; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        return min;
    }

    private double CalculateGreatestNumber(double[] arr)
    {
        double max = 0;
        int count = arr.Length;
        for (int i = 0; i < count; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }
}