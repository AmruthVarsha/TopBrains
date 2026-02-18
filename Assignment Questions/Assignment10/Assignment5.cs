// using System;
// using Microsoft.VisualBasic;

// public class Assignment5
// {
//     public static void Main(string[] args)
//     {
//         Chocolate chocolate = new Chocolate();

//         Console.Write("Enter the Chocolate flavour: ");
//         chocolate.Flavour = Console.ReadLine();
//         Console.Write("Enter the Chocolate quantity: ");
//         chocolate.Quantity = int.Parse(Console.ReadLine());
//         Console.Write("Enter the Chocolate Price per piece: ");
//         chocolate.PricePerUnit = int.Parse(Console.ReadLine());

//         if (chocolate.ValidateChocolateFlavour())
//         {
//             chocolate.CalculateDiscountedPrice(chocolate);
//             Console.WriteLine($"Flavour: {chocolate.Flavour}");
//             Console.WriteLine($"Quantity: {chocolate.Quantity}");
//             Console.WriteLine($"Price Per Unit: {chocolate.PricePerUnit}");
//             Console.WriteLine($"Total Price: {chocolate.TotalPrice}");
//             Console.WriteLine($"Discounted Price: {chocolate.DiscountedPrice}");
//         }
//         else
//         {
//             Console.WriteLine("Invalid Flavour");
//         }

//     }
// }

// public class Chocolate
// {
//     public string Flavour { get; set; }
//     public int Quantity { get; set; }
//     public int PricePerUnit { get; set; }
//     public double TotalPrice { get; set; }
//     public double DiscountedPrice { get; set; }

//     public bool ValidateChocolateFlavour()
//     {
//         switch (Flavour)
//         {
//             case "Dark":
//                 return true;
//             case "Milk":
//                 return true;
//             case "White":
//                 return true;
//             default:
//                 break;
//         }
//         return false;
//     }

//     public Chocolate CalculateDiscountedPrice(Chocolate chocolate)
//     {
//         double Discount = 0;
//         switch (chocolate.Flavour)
//         {
//             case "Dark":
//                 Discount = 18;
//                 break;
//             case "Milk":
//                 Discount = 12;
//                 break;
//             case "White":
//                 Discount = 6;
//                 break;
//             default:
//                 break;
//         }
//         chocolate.TotalPrice = chocolate.Quantity * chocolate.PricePerUnit;
//         chocolate.DiscountedPrice = chocolate.TotalPrice - (chocolate.TotalPrice * (Discount/100));
//         return chocolate;
//     }
// }