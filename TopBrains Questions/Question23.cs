using System;
using System.Collections.Generic;

public static class Extensions
{
    // Extension Method
    public static string[] DistinctById(this string[] items)
    {
        HashSet<string> seenIds = new HashSet<string>();
        List<string> result = new List<string>();

        foreach (var item in items)
        {
            if (string.IsNullOrEmpty(item)) continue;

            string[] parts = item.Split(':');

            if (parts.Length != 2) continue;

            string id = parts[0];
            string name = parts[1];

            if (!seenIds.Contains(id))
            {
                seenIds.Add(id);
                result.Add(name);
            }
        }

        return result.ToArray();
    }
}

class Program
{
    static void Main()
    {
        string[] items = {
            "1:Alice",
            "2:Bob",
            "1:Charlie",
            "3:David",
            "2:Eve"
        };

        var result = items.DistinctById();

        Console.WriteLine("Distinct Names:");
        foreach (var name in result)
        {
            Console.WriteLine(name);
        }
    }
}