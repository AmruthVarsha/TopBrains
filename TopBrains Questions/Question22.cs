using System;

class Program
{
    public static double? ComputeAverage(double?[] values)
    {
        double sum = 0;
        int count = 0;

        foreach (var val in values)
        {
            if (val.HasValue)
            {
                sum += val.Value;
                count++;
            }
        }

        // If no non-null values
        if (count == 0)
            return null;

        double avg = sum / count;

        // Round to 2 decimals (AwayFromZero)
        avg = Math.Round(avg, 2, MidpointRounding.AwayFromZero);

        return avg;
    }

    // Main for testing
    static void Main()
    {
        double?[] values = { 1.2, null, 2.5, 3.3, null };

        var result = ComputeAverage(values);

        if (result.HasValue)
            Console.WriteLine("Average: " + result.Value);
        else
            Console.WriteLine("Average: null");
    }
}