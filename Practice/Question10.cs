// using System;
// using System.Text;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string email=Console.ReadLine();
//         StringBuilder s1 = new StringBuilder();
//         s1.Append(email[0]);
//         int i;
//         for(i = 1; i < email.Length; i++)
//         {
//             if (email[i] == '@')
//             {
//                 break;
//             }
//             s1.Append('*');
//         }
//         s1.Append(email.Substring(i,email.Length-i));
//         Console.WriteLine(s1.ToString());
//     }
// }