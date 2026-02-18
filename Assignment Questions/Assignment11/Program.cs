// using System;
// using System.Diagnostics;
// using System.Reflection;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // Rectangle rectangle = new Rectangle(30,20);
//         // rectangle.GetArea();
//         // rectangle.Display();

//         Type t = typeof(string);

//         Console.WriteLine($"Name : {t.Name}"); 
//         Console.WriteLine($"Full Name : {t.FullName}"); 
//         Console.WriteLine($"Namespace : {t.Namespace}"); 
//         Console.WriteLine($"Base Type : {t.BaseType}"); 
        
//         Assembly executing = Assembly.GetExecutingAssembly();
//         Type[] types = executing.GetTypes();

//         foreach(var item in types)
//         {
//             Console.WriteLine($"Class : {item.Name}");

//             MethodInfo[] methods = item.GetMethods();
//             foreach(var method in methods)
//             {
//                 Console.WriteLine($"--> Method : {method.Name}");
//                 ParameterInfo[] parameters = method.GetParameters();
//                 foreach(var arg in parameters)
//                 {
//                     Console.WriteLine($"----> Parameters : {arg.Name}, Type : {arg.ParameterType}");
//                 }
//             }
//         }
//     }
// }

// [AttributeUsage(
//     AttributeTargets.Class | 
//     AttributeTargets.Constructor | 
//     AttributeTargets.Field | 
//     AttributeTargets.Method | 
//     AttributeTargets.Property , 
//     AllowMultiple = true)]

// public class DebugInfo : System.Attribute
// {
//     private int bugNo;
//     private string developer;
//     private string lastReview;
//     private string message;

//     public DebugInfo(int bg, string dev, string d)
//     {
//         this.bugNo = bg;
//         this.developer = dev;
//         this.lastReview = d;
//     }

//     public int BugNo
//     {
//         get{
//             return bugNo;
//         }
//     }

//     public string Developer
//     {
//         get
//         {
//             return developer;
//         }
//     }
//     public string LastReview
//     {
//         get
//         {
//             return lastReview;
//         }
//     }

//     public string Message
//     {
//         get
//         {
//             return message;
//         }
//         set
//         {
//             message = value;
//         }
//     }


// }


// public class Rectangle
// {
//     protected double length;
//     protected double width;

//     public Rectangle(double l,double w)
//     {
//         this.length = l;
//         this.width = w;
//     }

//     [DebugInfo(55, "Zara Ali", "19/10/2012",Message = "return type Mismatch")]

//     public double GetArea()
//     {
//         return length*width;
//     }
//     [DebugInfo(56,"Zara Ali","19/10/2012")]

//     public void Display()
//     {
//         Console.WriteLine(length);
//         Console.WriteLine(width);
//         Console.WriteLine(GetArea());
//     }
// }

// public class Student
// {
//     public int RollNo { get; set; }
//     public string Name { get; set; }

//     public Student(){
//         RollNo=0;
//         Name=string.Empty;
//     }

//     public Student(int rollno, string name)
//     {
//         this.RollNo=rollno;
//         this.Name=name;
//     }

//     public void DisplayData()
//     {
//         Console.WriteLine($"Roll Number: {RollNo}");
//         Console.WriteLine($"Name: {Name}");
//     }


// }