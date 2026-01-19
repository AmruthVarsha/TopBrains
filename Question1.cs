using System;
using System.Text;

public class TwoWords
{
    public static void Main(string[] args)
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        s2 = s2.ToLower();
        string vowels = "aeiou";
        StringBuilder newS1 = new StringBuilder();


        for(int i = 0; i < s1.Length; i++)
        {
            char ch = char.ToLower(s1[i]);
            if (s2.Contains(ch) && !vowels.Contains(ch))
            {
                continue;
            }
            newS1.Append(s1[i]);
        }


        for(int i = 0; i < newS1.Length-1; i++)
        {
            if (newS1[i] == newS1[i + 1])
            {
                newS1.Remove(i,1);
                i--;
            }
        }

        Console.WriteLine(newS1.ToString());



    }
}