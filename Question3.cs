using System;
using System.Text;

class InventoryNameCleanup
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        s = s.Trim();
        string[] words = s.Split(" ",StringSplitOptions.RemoveEmptyEntries);

        for(int i = 0; i < words.Length; i++)
        {
            StringBuilder s1=new StringBuilder();
            s1.Append(char.ToUpper(words[i][0])); 
            for(int j = 1; j < words[i].Length; j++)
            {
                if(char.ToLower(words[i][j - 1]) == char.ToLower(words[i][j]))
                {
                    continue;
                }
                s1.Append(char.ToLower(words[i][j]));
            }
            words[i] = s1.ToString();
        }
        s = String.Join(" ",words);
        Console.WriteLine(s);
    }
}