// using System;
// using System.Text;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         string s = Console.ReadLine();
//         StringBuilder s1= new StringBuilder();
//         int count=1;
//         for(int i = 0,j=0; i < s.Length; i++)
//         {
//             if (i == 0)
//             {
//                 s1.Append(s[i]);
//             }
//             else if (s[i] == s[j])
//             {
//                 count++;
//             }
//             else if (s[i] != s[j])
//             {
//                 if (count > 1)
//                 {
//                     s1.Append(count);
//                     count=1;
//                 }
//                 j=i;
//                 s1.Append(s[j]);
//             }
//         }
//         if(count!=1){
//             s1.Append(count);
//         }
//         Console.WriteLine(s1.ToString());
//     }
// }