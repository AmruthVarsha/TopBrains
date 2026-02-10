using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
     // =========================
    // Program (Menu-Driven)
    // =========================
    class Program
    {
        static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                try
                {
                    // TODO:
                    // Implement menu handling logic using switch-case
                    // Prompt user inputs
                    // Call appropriate UniversitySystem methods
                    string studentid,courseCode;
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter course code: ");
                            string code = Console.ReadLine();
                            Console.Write("Enter course name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter course credits: ");
                            int credits = int.Parse(Console.ReadLine());
                            Console.Write("Enter course capacity: ");
                            int maxCapacity = int.Parse(Console.ReadLine());
                            Console.Write("Enter how many prerequisite courses: ");
                            int prerequisiteCount = int.Parse(Console.ReadLine());
                            List<string> prerequisites = new List<string>();
                            for(int i = 0; i < prerequisiteCount; i++)
                            {
                                Console.Write("Enter prerequisite course code: ");
                                prerequisites.Add(Console.ReadLine());
                            }
                            system.AddCourse(code,name,credits,maxCapacity,prerequisites);
                            break;
                        case "2":
                            Console.Write("Enter student id: ");
                            string id = Console.ReadLine();
                            Console.Write("Enter student name: ");
                            string studentName = Console.ReadLine();
                            Console.Write("Enter student major: ");
                            string major = Console.ReadLine();
                            Console.Write("Enter max credits: ");
                            int maxCredits = int.Parse(Console.ReadLine());
                            Console.Write("Enter how many completed courses: ");
                            int completedCount = int.Parse(Console.ReadLine());
                            List<string> completedCourses = new List<string>();
                            for(int i = 0; i < completedCount; i++)
                            {
                                Console.Write("Enter completed course code: ");
                                completedCourses.Add(Console.ReadLine());
                            }
                            system.AddStudent(id,studentName,major,maxCredits,completedCourses);
                            break;
                        case "3":
                            Console.Write("Enter student id: ");
                            studentid = Console.ReadLine();
                            Console.Write("Enter Course code: ");
                            courseCode = Console.ReadLine();
                            system.RegisterStudentForCourse(studentid,courseCode);
                            break;
                        case "4":
                            Console.Write("Enter student id: ");
                            studentid = Console.ReadLine();
                            Console.Write("Enter Course code: ");
                            courseCode = Console.ReadLine();
                            system.DropStudentFromCourse(studentid,courseCode);
                            break;
                        case "5":
                            system.DisplayAllCourses();
                            break;
                        case "6":
                            Console.Write("Enter student id: ");
                            studentid = Console.ReadLine();
                            system.DisplayStudentSchedule(studentid);
                            break;
                        case "7":
                            system.DisplaySystemSummary();
                            break;
                        case "8":
                            exit=true;
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

