using System;
using System.Collections.Generic;
using System.Text.Json;

public record Student(string Name, int Score);

class Program
{
    public static string ProcessStudents(string[] items, int minScore)
    {
        List<Student> students = new List<Student>();

        foreach (var item in items)
        {
            if (string.IsNullOrEmpty(item)) continue;

            int idx = item.IndexOf(':');
            if (idx == -1) continue;

            string name = item.Substring(0, idx);
            string scorePart = item.Substring(idx + 1);

            if (!int.TryParse(scorePart, out int score)) continue;

            students.Add(new Student(name, score));
        }

        // Filter + Sort
        students.Sort((a, b) =>
        {
            int scoreCompare = b.Score.CompareTo(a.Score); // Descending
            if (scoreCompare != 0) return scoreCompare;

            return a.Name.CompareTo(b.Name); // Ascending
        });

        List<Student> filtered = new List<Student>();
        foreach (var s in students)
        {
            if (s.Score >= minScore)
                filtered.Add(s);
        }

        // Serialize to JSON
        string json = JsonSerializer.Serialize(filtered);

        return json;
    }

    // Main for testing
    static void Main()
    {
        string[] items = {
            "Alice:90",
            "Bob:80",
            "Charlie:90",
            "David:70"
        };

        int minScore = 80;

        string result = ProcessStudents(items, minScore);

        Console.WriteLine(result);
    }
}