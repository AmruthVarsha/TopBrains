// using System;
// using System.Text;
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string input = Console.ReadLine();
//         string[] inputs = input.Split(" ");

//         Dictionary<string,int> dict = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

//         foreach(string i in inputs)
//         {
//             if (dict.ContainsKey(i))
//             {
//                 dict[i] = dict[i] +1;
//                 continue;
//             }
//             dict.Add(i,1);

//         }

//         foreach(KeyValuePair<string,int> i in dict)
//         {
//             Console.WriteLine($"{i.Key}: {i.Value}");
//         }
//     }
// }