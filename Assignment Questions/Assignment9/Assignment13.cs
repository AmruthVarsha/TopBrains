using System;
using System.IO;
public class Assignment13
{
    public const string File_Path = "attendence.txt";
    public static void Main(string[] args)
    {
        while (true)
        {
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                AddAttendence();
                Console.WriteLine("Attendance recorded.");
            }
            else if(choice == 2)
            {
                Console.WriteLine("--- Attendance Log ---");
                ViewAttendence();
            }
            else if(choice == 3)
            {
                return;
            }

            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }

    public static void AddAttendence()
    {

        try{
            using( StreamWriter writer = new StreamWriter(File_Path, true)){

                int id = int.Parse(Console.ReadLine());
                string name= Console.ReadLine();
                string status= Console.ReadLine();
                string date= DateTime.Now.ToString("dd/MM/yyyy");
                writer.WriteLine($"{date} | {id} | {name} | {status}");
            }
        }
        catch(IOException e)
        {
            Console.WriteLine("File error occurred.");
        }
    }

    public static void ViewAttendence()
    {
        if (!File.Exists(File_Path))
        {
            Console.WriteLine("No attendance records found.");
            return;
        }
        try{
            using(StreamReader reader = new StreamReader(File_Path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch(IOException e)
        {
            Console.WriteLine("File error occurred.");
        }
    }
}