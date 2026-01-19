using System;

public class EmpDictionary
{
    public static void Main(string[] args)
    {
        Dictionary<int,int> dict = new Dictionary<int, int>();
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            int id = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            dict.Add(id,salary);
        }

        int total = 0;

        foreach(KeyValuePair<int,int> i in dict)
        {
            total+=i.Value;
        }

        Console.WriteLine(total);

    }
}

