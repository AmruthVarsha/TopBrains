// using System;
// using System.Text.RegularExpressions;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string s = Console.ReadLine();

//         string pattern =
//         @"^(?=.{5,15}$)[A-Za-z](?!.*\.\.)(?!.*__)(?!.*\._)(?!.*_\.)(?!.*[._]$)[A-Za-z0-9._]+$";

//         if (Regex.IsMatch(s, pattern))
//         {
//             Console.WriteLine("Valid Username");
//         }
//         else
//         {
//             Console.WriteLine("Invalid Username");
//         }
//     }
// }
