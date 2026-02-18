// using System;

// public class Program
// {
//     public static Dictionary<int,Jewellery> jewelleryDetails = new Dictionary<int, Jewellery>
//     {
//         {1,new Jewellery{Id="J001",Type="Necklace",Material="Gold",Price=200000}},
//         {2,new Jewellery{Id="J002",Type="Necklace",Material="Platinum",Price=2000000}},
//         {3,new Jewellery{Id="J003",Type="Bracelet",Material="Silver",Price=9000}},
//         {4,new Jewellery{Id="J004",Type="Earrings",Material="Gold,Diamonds",Price=50000}},
//         {5,new Jewellery{Id="J005",Type="Ring",Material="Platinum,Diamonds",Price=4000000}}
//     };

//     public static void Main(string[] args)
//     {
//         bool exit = false;
//         while (!exit)
//         {
//             Console.WriteLine("1. Get Details\n2. Update Price\n3. Exit");
//             Console.Write("Choice: ");
//             int choice =int.Parse(Console.ReadLine());
//             JewelleryUtility jewelleryUtility = new JewelleryUtility();
//             switch (choice)
//             {
//                 case 1:
//                     Console.Write("Enter id to get Details: ");
//                     string id = Console.ReadLine();
//                     Dictionary<string,string> dict = jewelleryUtility.GetJewelleryDetails(id);
//                     if (dict.Count == 0)
//                     {
//                         Console.WriteLine("Invalid id!!");
//                         break;
//                     }
//                     string[] type = dict[id].Split("_");
//                     Console.WriteLine($"Id: {id} , Type: {type[0]} , Material: {type[1]}");
//                     break;
//                 case 2:
//                     Console.Write("Enter the id to update price of: ");
//                     string id2 = Console.ReadLine();
//                     Console.Write("Enter the new price: ");
//                     int price = int.Parse(Console.ReadLine());
//                     Dictionary<string,Jewellery> result = jewelleryUtility.UpdateJewelleryPrice(id2,price);
//                     Jewellery jewellery = result[id2];
//                     Console.WriteLine($"Id: {jewellery.Id} , Type: {jewellery.Type} , Material: {jewellery.Material} , Price: {jewellery.Price}");
//                     break;
//                 case 3:
//                     exit = true;
//                     break;
//                 default:
//                     Console.WriteLine("Invalid Input");
//                     break; 

//             }
//         }
//     }
// }

// public class Jewellery
// {
//     public string Id {get; set;}
//     public string Type {get; set;}
//     public string Material {get; set;}
//     public int Price {get; set;}
// }

// public class JewelleryUtility
// {
//     public Dictionary<string,string> GetJewelleryDetails(string id)
//     {
//         Dictionary<string,string> result = new Dictionary<string,string>();
//         bool hasJewellery = Program.jewelleryDetails.Any(j => j.Value.Id == id);
//         if(hasJewellery){
//             Jewellery jewellery = Program.jewelleryDetails.First(j => j.Value.Id == id).Value;
//             result.Add(jewellery.Id,jewellery.Type+"_"+jewellery.Material);
//         }
//         return result;
//     }

//     public Dictionary<string,Jewellery> UpdateJewelleryPrice(string id,int price)
//     {
//         Dictionary<string,Jewellery> result = new Dictionary<string, Jewellery>();
//         Jewellery jewellery = Program.jewelleryDetails.First(j => j.Value.Id == id).Value;
//         jewellery.Price = price;
//         result.Add(jewellery.Id,jewellery);

//         return result;
//     }
// }