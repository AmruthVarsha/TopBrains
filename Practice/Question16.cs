// using System;
// using System.Runtime.Serialization;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         HashSet<char> set=new HashSet<char>();
//         string s=Console.ReadLine();
//         int count=0,max=0;

//         for(int i=0,j=0;i<s.Length;i++)
//         {
//             if (set.Contains(s[i]))
//             {
//                 while (set.Contains(s[i]))
//                 {
//                     set.Remove(s[j]);
//                     j++;
//                     count--;
//                 }
//             }
//             set.Add(s[i]);
//             count++;
//             max=Math.Max(count,max);
//         }
//         Console.WriteLine(max);
 
//     }
// }