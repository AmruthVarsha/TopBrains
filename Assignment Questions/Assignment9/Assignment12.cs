using System;
using System.Runtime.CompilerServices;

public class Assignment12
{
    public static void Main(string[] args)
    {
        string operation = Console.ReadLine();
        string input = Console.ReadLine();

        if(operation == "reverse")
        {
            Action<string> printReverseString=ReverseString;
            printReverseString(input);
        }
        else if(operation == "palindrome")
        {
            Func<string,bool> isPalindrome = PalindromeString;
            Console.WriteLine($"Is palindrome: {isPalindrome(input)}");
        }
        else
        {
            Console.WriteLine("Invalid operation.");
        }

        
    }

    public static void ReverseString(string s)
    {
        Console.Write("Reverse string: ");
        for(int i = s.Length - 1; i >= 0; i--)
        {
            Console.Write(s[i]);
        }
    }

    public static bool PalindromeString(string s)
    {
        for(int i = 0, j = s.Length - 1; i < s.Length / 2; i++, j--)
        {
            if (s[i] != s[j])
            {
                return false;
            }
        }
        return true;
    }
}