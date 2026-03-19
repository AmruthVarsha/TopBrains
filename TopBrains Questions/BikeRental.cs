using System;
using System.Collections.Generic;

namespace BikeRental
{
    // Bike Class
    public class Bike
    {
        public string Model { get; set; }
        public int PricePerDay { get; set; }
        public string Brand { get; set; }
    }

    // Utility Class
    public class BikeUtility
    {
        // Given Dictionary
        public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();

        // Add Bike Details
        public void AddBikeDetails(string model, string brand, int pricePerDay)
        {
            Bike bike = new Bike()
            {
                Model = model,
                Brand = brand,
                PricePerDay = pricePerDay
            };

            int key = bikeDetails.Count + 1;
            bikeDetails.Add(key, bike);
        }

        // Group Bikes By Brand
        public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
        {
            SortedDictionary<string, List<Bike>> grouped = new SortedDictionary<string, List<Bike>>();

            foreach (var item in bikeDetails)
            {
                Bike bike = item.Value;

                if (!grouped.ContainsKey(bike.Brand))
                {
                    grouped[bike.Brand] = new List<Bike>();
                }

                grouped[bike.Brand].Add(bike);
            }

            return grouped;
        }
    }

    // Program Class
    class Program
    {
        static void Main(string[] args)
        {
            BikeUtility utility = new BikeUtility();

            while (true)
            {
                Console.WriteLine("\n1. Add Bike Details");
                Console.WriteLine("2. Group Bikes By Brand");
                Console.WriteLine("3. Exit");

                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter the model: ");
                        string model = Console.ReadLine();

                        Console.Write("Enter the brand: ");
                        string brand = Console.ReadLine();

                        Console.Write("Enter the price per day: ");
                        int price = Convert.ToInt32(Console.ReadLine());

                        utility.AddBikeDetails(model, brand, price);

                        Console.WriteLine("\nBike details added successfully");
                        break;

                    case 2:
                        var grouped = utility.GroupBikesByBrand();

                        foreach (var brandGroup in grouped)
                        {
                            foreach (var bike in brandGroup.Value)
                            {
                                Console.WriteLine($"{brandGroup.Key} {bike.Model}");
                            }
                        }
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}