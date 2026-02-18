// using System;
// using System.Text.RegularExpressions;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         string a  = Console.ReadLine();
//         bool result = Regex.IsMatch(a , @"\d{4}"); // Tries to find if the sentence has 4 digits true if it has 4 or more false if less.
//         Console.WriteLine(result);

//         Match m = Regex.Match("Amount: 5000",@"\d+");
//         Console.WriteLine(m.Value);

//         MatchCollection matches = Regex.Matches("10 20 30",@"\d+");
//         foreach(Match i in matches)
//         {
//             Console.WriteLine(i.Value);
//         }

//         string result  = Regex.Replace("ID123" , @"\d" , "*");
//         Console.WriteLine(result);

//         string[] parts = Regex.Split("a,b;c d,e,f;g h@1",@"[,; @]");
//         foreach(string i in parts)
//         {
//             Console.WriteLine(i);
//         }


//         bool result = Regex.IsMatch("12345" , @"^\d{5}$"); //meaning in between start ^ and end $ only five digits should be there.
//         Console.WriteLine(result);


//         Match m = Regex.Match("Date: 18-01-2025", @"\d{2}-\d{2}-\d{4}");
//         Console.WriteLine(m.Value);
//     }
// }