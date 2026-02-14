using System;
using System.Text.RegularExpressions;

public class ErrorSeperation
{
    public static string LogFilePath = "log.txt"; 
    public static string ErrorFilePath = "error.txt"; 
    public static void Main(string[] args)
    {
        string errorLines = @"^ERROR\s*\w+";
        using(StreamWriter sw = new StreamWriter(ErrorFilePath, true))
        {
            using(StreamReader sr= new StreamReader(LogFilePath))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    if (Regex.IsMatch(line, errorLines))
                    {
                        sw.WriteLine(line);
                    }
                }
            }
        }
    }
}