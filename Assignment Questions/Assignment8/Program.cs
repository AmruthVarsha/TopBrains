using System;
using System.Formats.Asn1;
using System.Linq.Expressions;

class Program
{
    public static void Main(string[] args)
    {
        // string filePath = "Employee.dat";
        // using(FileStream fileStream = new FileStream(filePath,FileMode.Create))
        // using(BinaryWriter writer = new BinaryWriter(fileStream)){
        //     writer.Write(101);
        //     writer.Write("Avi");
        //     writer.Write(45000.75);
        //     writer.Write(true);
        // }


        // Console.WriteLine("Binary file Written Successfully.");


        // string path = "MyTestFile1.txt";
        // FileInfo f1 = new FileInfo(path);
        // File.Create(path);
        // Console.WriteLine("File has been created");


        // FileInfo f1 = new FileInfo("MyTestFile2.txt");
        // StreamWriter str = f1.CreateText();
        // str.WriteLine("hello");
        // Console.WriteLine("File has been created with text");
        // str.Close();


        // string path1 = @"D:\.NET\Jan9Day15\MyTestFile1.txt";
        // string path2 = @"D:\.NET\Jan9Day15\MyTestFile2.txt";

        // FileInfo fi1 = new FileInfo(path1);
        // FileInfo fi2 = new FileInfo(path2);
        // fi1.CopyTo(path2,true);
        // Console.WriteLine($"{path1} is copied to {path2}");

        // string path1 = @"D:\.NET\Jan9Day15\MyTestFile1.txt";
        // string path2 = @"D:\.NET\Jan9Day15\MyTestFile2.txt";

        // FileInfo fi1 = new FileInfo(path1);
        // FileInfo fi2 = new FileInfo(path2);
        // fi1.MoveTo(path2);
        // Console.WriteLine($"{path1} is copied to {path2}");


        // FileInfo fi = new FileInfo(@"D:\.NET\Jan9Day15\MyTestFile2.txt");
        // Console.WriteLine(fi.Name);
        // Console.WriteLine(fi.CreationTime.ToLongTimeString());
        // Console.WriteLine(fi.LastAccessTime.ToLongDateString());
        // Console.WriteLine(fi.Length.ToString());
        // Console.WriteLine(fi.Extension);
        // Console.WriteLine(fi.Exists);

        Assignment assignment = new Assignment();
        assignment.Task1();
        assignment.Task2();
        assignment.Task3();



        
    }
}