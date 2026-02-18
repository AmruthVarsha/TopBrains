// using System;
// using System.Collections.Generic;

// public class Student
// {
//     public string Id { get; set; }
//     public string Name { get; set; }
//     public string Course { get; set; }
//     public int Marks { get; set; }
// }

// public class Program
// {
//     public static Dictionary<int, Student> studentDetails =
//         new Dictionary<int, Student>
//     {
//         {1,new Student(){Id = "ST01" , Name = "Alice" , Course = "DataScience", Marks = 93}},
//         {2,new Student(){Id = "ST02" , Name = "Bob" , Course = "AI", Marks = 85}}
//     };

//     public static void Main(string[] args)
//     {
//         bool endLoop = false;

//         while (!endLoop)
//         {
//             Console.WriteLine("1. Get Student Details");
//             Console.WriteLine("2. Update Marks");
//             Console.WriteLine("3. Exit");
//             Console.Write("Enter your choice: ");

//             int choice = int.Parse(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:

//                     StudentUtility obj = new StudentUtility();

//                     Console.Write("Enter the student id: ");
//                     string id = Console.ReadLine();

//                     Dictionary<string, string> dict =
//                         obj.GetStudentDetails(id);

//                     if (dict.Count == 0)
//                     {
//                         Console.WriteLine("Student id not found");
//                     }
//                     else
//                     {
//                         foreach (KeyValuePair<string, string> i in dict)
//                         {
//                             Console.WriteLine(i.Key + " " + i.Value);
//                         }
//                     }

//                     break;

//                 case 2:

//                     StudentUtility obj2 = new StudentUtility();

//                     Console.Write("Enter student id: ");
//                     string id2 = Console.ReadLine();

//                     Console.Write("Enter student new Marks: ");
//                     int marks = int.Parse(Console.ReadLine());

//                     Dictionary<string, Student> result =
//                         obj2.UpdateStudentMarks(id2, marks);

//                     if (result.Count == 0)
//                     {
//                         Console.WriteLine("Student id not found");
//                     }
//                     else
//                     {
//                         foreach (KeyValuePair<string, Student> i in result)
//                         {
//                             Console.WriteLine("Marks Updated Successfully");
//                             Console.WriteLine(
//                                 i.Key + " " +
//                                 i.Value.Name + " " +
//                                 i.Value.Course + " " +
//                                 i.Value.Marks
//                             );
//                         }
//                     }

//                     break;

//                 case 3:

//                     endLoop = true;
//                     Console.WriteLine("Thank you");

//                     break;

//                 default:
//                     Console.WriteLine("Invalid Choice");
//                     break;
//             }
//         }
//     }
// }

// public class StudentUtility
// {
//     public Dictionary<string, string> GetStudentDetails(string id)
//     {
//         Dictionary<string, string> result =
//             new Dictionary<string, string>();

//         foreach (KeyValuePair<int, Student> i in Program.studentDetails)
//         {
//             if (i.Value.Id == id)
//             {
//                 result.Add(
//                     i.Value.Id,
//                     i.Value.Name + "_" + i.Value.Course
//                 );

//                 break;
//             }
//         }

//         return result;
//     }

//     public Dictionary<string, Student> UpdateStudentMarks(string id, int marks)
//     {
//         Dictionary<string, Student> result =
//             new Dictionary<string, Student>();

//         foreach (KeyValuePair<int, Student> i in Program.studentDetails)
//         {
//             if (i.Value.Id == id)
//             {
//                 i.Value.Marks = marks;

//                 result.Add(i.Value.Id, i.Value);

//                 break;
//             }
//         }

//         return result;
//     }
// }
