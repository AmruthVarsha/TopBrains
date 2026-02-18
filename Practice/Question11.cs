// using System;

// public class program
// {
//     public static void Main(string[] args)
//     {
//         Stack<char> stack = new Stack<char>();
//         string s=Console.ReadLine();
//         foreach(char i in s)
//         {
//             if (stack.Count == 0)
//             {
//                 stack.Push(i);
//             }
//             else if((stack.Peek()=='{' && i=='}') || (stack.Peek()=='[' && i==']') || (stack.Peek()=='(' && i == ')'))
//             {
//                 stack.Pop();
//             }
//             else
//             {
//                 stack.Push(i);
//             }
//         }
//         if (stack.Count == 0)
//         {
//             Console.WriteLine("Valid");
//             return;
//         }
//         Console.WriteLine("Invalid");
//     }
// }