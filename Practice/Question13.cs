// using System;
// using System.Text.RegularExpressions;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string s = Console.ReadLine();

//         string pattern =
//         @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%^&*+\-/])[A-Za-z0-9!@#$%^&*+\-/]{8,20}$";

//         if (Regex.IsMatch(s, pattern))
//         {
//             Console.WriteLine("Password is strong");
//             return;
//         }

//         Console.WriteLine("Password is weak");
//     }
// }
