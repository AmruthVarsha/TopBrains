// using System;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string s = Console.ReadLine();
//         HashSet<char> set = new HashSet<char>();
//         int left=0,MaxLength=0;
//         string result=string.Empty;
//         for(int right=0;right<s.Length;right++)
//         {
//             while (set.Contains(s[right]))
//             {
//                 set.Remove(s[left]);
//                 left++;
//             }
//             set.Add(s[right]);
//             int currentLength = right-left+1;
//             if (currentLength > MaxLength)
//             {
//                 MaxLength=currentLength;
//                 result=s.Substring(left,currentLength);
//             }

//         }
//         Console.WriteLine(MaxLength+" "+result);
//     }
// }