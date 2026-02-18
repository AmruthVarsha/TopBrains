// using System;
// using System.Data;



// public class Program
// {
//     // public delegate void DisplayMessage(); 

//     public delegate void Notify();

//     public event Notify NotifyEvent;
//     public static void Main(string[] args)
//     {
//         // DisplayMessage m = Message;

//         // m();


//         Notify notify = Message;
//         notify+=Email;
//         notify+=Sms;

//         notify();

//         NumberChecker numberChecker = new NumberChecker();
//         numberChecker.OddNumberEvent += OddNum;

//         numberChecker.OddChecker(5);
//     }

//     public static void Message()
//     {
//         Console.WriteLine("Hello from Delegate");
//     }

//     public static void Email()
//     {
//         Console.WriteLine("Email sent");
//     }

//     public static void Sms()
//     {
//         Console.WriteLine("Sms Sent");
//     }

//     public static void OddNum()
//     {
//         Console.WriteLine("Odd Number Detected");
//     }
// }

// class NumberChecker
// {
//     public delegate void OddNumber();
//     public event OddNumber OddNumberEvent;

//     public void OddChecker(int num)
//     {
//         if(num %2 != 0)
//         {
//             OddNumberEvent?.Invoke();
//         }
//     }
// }