using System;
using System.Collections.Specialized;
using System.IO;


public class Assignment14
{
    public const string File_Path = "error_log.txt";
    public static void Main(string[] args)
    {
        while (true)
        {
            int choice = int.Parse(Console.ReadLine());

            if(choice == 1)
            {
                AddRecord();
                Console.WriteLine("Error logged successfully");
            }
            else if(choice == 2)
            {
                ViewRecord();
            }
            else if(choice == 3)
            {
                File.Delete(File_Path);
                Console.WriteLine("Log cleared Successfully");
            }
            else if(choice == 4)
            {
                return;
            }
            else
            {
                Console.WriteLine("invalid input");
            }

        }
    }

    public static void AddRecord()
    {
        try
        {
            using(StreamWriter sw = new StreamWriter(File_Path,true)){
                string errorString= Console.ReadLine();
                string date = DateTime.Now.ToString("dd/MM/yyyy");
                sw.WriteLine($"{date} : {errorString}");
            }
        }
        catch(IOException e)
        {
            Console.WriteLine("File Error occured");
        }
    }

    public static void ViewRecord()
    {
        if (!File.Exists(File_Path))
        {
            Console.WriteLine("File does not Exist");
            return;
        }

        try
        {
            using(StreamReader sr = new StreamReader(File_Path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("File Error Occured");
        }

    }
}