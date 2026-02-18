// using System;
// using System.ComponentModel;
// using System.Runtime.ConstrainedExecution;

// public class Assignment2
// {
//     public static void Main(string[] args)
//     {
//         Membership membership = new Membership();

//         Console.Write("Enter the tier (Basic, Premium, Elite): ");
//         membership.Tier = Console.ReadLine();
//         Console.Write("Enter duration in Months: ");
//         membership.DurationInMonths = int.Parse(Console.ReadLine());
//         Console.Write("Enter base price per Month: ");
//         membership.BasePricePerMonth = double.Parse(Console.ReadLine());

//         if (membership.ValidateEnrollment())
//         {
//             Console.WriteLine("Enrollment Successfull");
//             Console.WriteLine($"Total bill is: {membership.CalculateTotalBill()}");
//         }
//     }
// }

// public class Membership
// {
//     public string Tier { get; set; }
//     public int DurationInMonths { get; set; }
//     public double BasePricePerMonth { get; set; }

//     public bool ValidateEnrollment()
//     {
//         try{
//             if(!Tier.Equals("Basic") && !Tier.Equals("Premium") && !Tier.Equals("Elite"))
//             {
//                 throw new InvalidTierException("Tier not recognized. Please choose an available membership plan.");
//             }
//             if(DurationInMonths <= 0)
//             {
//                 throw new Exception("Duration must be at least one month.");
//             }
//         }
//         catch(InvalidTierException e)
//         {
//             Console.WriteLine(e.Message);
//             return false;
//         }
//         catch(Exception e)
//         {
//             Console.WriteLine(e.Message);
//             return false;
//         }
//         return true;

//     }

//     public double CalculateTotalBill()
//     {
//         double total = DurationInMonths * BasePricePerMonth;
//         double discount =0;
//         if(Tier.Equals("Basic"))
//         {
//             discount = 2;
//         }
//         else if(Tier.Equals("Premium"))
//         {
//             discount = 7;
//         }
//         else if(Tier.Equals("Elite"))
//         {
//             discount = 12;
//         }

//         return total - total*(discount/100);
//     }
// }

// public class InvalidTierException : Exception
// {
//     public InvalidTierException(string Message) : base(Message)
//     {
        
//     }
// }