// using System;
// using System.Net.Http.Headers;

// public class Assignment4
// {
//     public static void Main(string[] args)
//     {
//         ShipmentDetails shipment = new ShipmentDetails();
//         Console.Write("Enter Shipment code: ");
//         shipment.ShipmentCode = Console.ReadLine();
//         Console.Write("Enter Shipment mode: ");
//         shipment.TransportMode = Console.ReadLine();
//         Console.Write("Enter Shipment weight: ");
//         shipment.Weight = double.Parse(Console.ReadLine());
//         Console.Write("Enter Shipment Storage Days: ");
//         shipment.StorageDays = int.Parse(Console.ReadLine());

//         if (shipment.ValidateShipmentCode())
//         {
//             Console.WriteLine($"The total shipping cost is {shipment.CalculateTotalCost():F2}");
//         }
//         else
//         {
//             Console.WriteLine("Invalid shipment code");
//         }

        
//     }
// }

// public class Shipment
// {
//     public string ShipmentCode { get; set; }
//     public string TransportMode { get; set; }
//     public double Weight {get; set;}
//     public int StorageDays { get; set; }


// }

// public class ShipmentDetails : Shipment
// {
//     public bool ValidateShipmentCode()
//     {
//         if(ShipmentCode.Length == 7 && ShipmentCode.StartsWith("GC#"))
//         {
//             return int.TryParse(ShipmentCode.Substring(3) , out _);
//         }
//         return false;
//     }

//     public double CalculateTotalCost()
//     {
//         double ratePerKg = 0;
//         if (TransportMode.Equals("Sea"))
//         {
//             ratePerKg = 15;
//         }
//         else if (TransportMode.Equals("Air"))
//         {
//             ratePerKg = 50;
//         }
//         else if (TransportMode.Equals("Land"))
//         {
//             ratePerKg = 25;
//         }
//         double total = (Weight * ratePerKg) + Math.Sqrt(StorageDays);

//         return total;
//     }
// }