// using System;
// using System.Text;
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string s = Console.ReadLine();
//         StringBuilder s1=new StringBuilder();
//         HashSet<char> set=new HashSet<char>();
//         for(int i = 0; i < s.Length; i++)
//         {
//             if (set.Contains(s[i]))
//             {
//                 continue;
//             }
//             set.Add(s[i]);
//             s1.Append(s[i]);
//         }

//         Console.WriteLine(s1.ToString());
//     }
// }