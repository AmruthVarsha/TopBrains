// using System;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string s=Console.ReadLine();
//         for(int i=0;i<s.Length;i++)
//         {
//             Palindrome(s,i,i);
//             Palindrome(s,i,i+1);
//         }
//     }

//     public static void Palindrome(string s,int left,int right)
//     {
//         while(left>=0 && right<s.Length && s[left] == s[right])
//         {
//             Console.WriteLine(s.Substring(left,right-left+1));
//             left--;
//             right++;
//         }
        
//     }
// }