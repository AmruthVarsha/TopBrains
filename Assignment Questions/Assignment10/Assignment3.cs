// using System;

// public class Assignment3
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("1.In-House\n2.Visiting\nChoose consultant type");
//             int choice = int.Parse(Console.ReadLine());
            
//             Consultant doc = (choice == 1) ? new InHouse() : new Visiting();

//             Console.WriteLine("Enter the doctor id");
//             doc.Id = Console.ReadLine();

//             if (doc.ValidateConsultantId())
//             {
//                 Console.WriteLine("Enter name");
//                 doc.Name = Console.ReadLine();

//                 if (doc is InHouse ih)
//                 {
//                     Console.WriteLine("Enter monthly stipend");
//                     ih.MonthlyStipend = double.Parse(Console.ReadLine());
//                 }
//                 else if (doc is Visiting v)
//                 {
//                     Console.WriteLine("Enter consultations count");
//                     v.ConsultationsCount = int.Parse(Console.ReadLine());
//                     Console.WriteLine("Enter rate per visit");
//                     v.RatePerVisit = int.Parse(Console.ReadLine());
//                 }

//                 doc.CalculatePayout();
//                 Console.WriteLine($"Doctor ID : {doc.Id}, Name : {doc.Name}, Payout : {doc.PayoutAmount}");
//             }
//             else
//             {
//                 Console.WriteLine("Invalid doctor id");
//             }
//         }

// }



// public abstract class Consultant
// {
//     public string Id { get; set; }
//     public string Name { get; set; }
//     public double PayoutAmount { get; set; }
    
//     public bool ValidateConsultantId()
//     {
//         if(Id.Length ==6 && Id.StartsWith("DR"))
//         {
//             return int.TryParse(Id.Substring(2), out _);
//         }
//         return false;
//     }
//     public abstract Consultant CalculatePayout();
// }

// public class InHouse : Consultant
// {
//     public double MonthlyStipend { get; set; }

//         public override Consultant CalculatePayout()
//         {
//             double allowance = 0.20 * MonthlyStipend;
//             double bonus = 0.10 * MonthlyStipend;
//             this.PayoutAmount = MonthlyStipend + allowance + bonus;
//             return this;
//         }
    
// }

// public class Visiting : Consultant
// {
//         public int ConsultationsCount { get; set; }
//         public int RatePerVisit { get; set; }

//         public override Consultant CalculatePayout()
//         {
//             this.PayoutAmount = ConsultationsCount * RatePerVisit;
//             return this;
//         }

// }