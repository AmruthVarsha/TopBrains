using System;
using System.Globalization;
using Domain;
using Services;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagementService service = new ManagementService();

            while (true)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Update Stock");
                Console.WriteLine("4. Get Highest priority product");
                Console.WriteLine("5. Display data");
                Console.WriteLine("6. Exit");

                // TODO: Read user choice

                int choice = 0; // TODO
                Console.Write("Enter the choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                string sku,name;
                int priority,stock,threshold;

                try{
                    switch (choice)
                    {
                        case 1:
                            Product product = null;
                            Console.WriteLine("Enter the type of Product (Electronic,Perishable,Fragile): ");
                            string type = Console.ReadLine();
                            Console.Write("Enter sku: ");
                            sku = Console.ReadLine();
                            Console.Write("Enter product Name: ");
                            name = Console.ReadLine();
                            Console.Write("Enter Priority (1-10, 1 is the highest priority): ");
                            priority = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Stock: ");
                            stock = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter threshold: ");
                            threshold = Convert.ToInt32(Console.ReadLine());
                            if (type.Equals("Electronic", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.Write("Enter Brand: ");
                                string brand = Console.ReadLine();
                                product = new Electronics(){SKU=sku,Name=name,PriorityLevel=priority,Stock=stock,Threshold=threshold,Brand=brand};
                            }
                            else if(type.Equals("Perishable", StringComparison.OrdinalIgnoreCase)){
                                Console.Write("Enter Expiry Date(yyyy-mm-dd): ");
                                DateTime date = DateTime.Parse(Console.ReadLine());
                                product = new Perishable(){SKU=sku,Name=name,PriorityLevel=priority,Stock=stock,Threshold=threshold,ExpiryDate=date};
                            }
                            else if(type.Equals("Fragile", StringComparison.OrdinalIgnoreCase)){
                                Console.Write("Enter fragile level: ");
                                string fragileLevel = Console.ReadLine();
                                product = new FragileItem(){SKU=sku,Name=name,PriorityLevel=priority,Stock=stock,Threshold=threshold,FragilityLevel=fragileLevel};
                            }
                            if(product == null)
                            {
                                Console.WriteLine("Invalid product type: ");
                                break;
                            }
                            service.AddProduct(priority,product);
                            break;
                        case 2:
                            Console.Write("Enter the sku of the product to be removed");
                            sku = Console.ReadLine();
                            service.RemoveProduct(sku);
                            break;
                        case 3:
                            // TODO: Update entity
                            Console.Write("Enter the sku of the product to update stock: ");
                            sku = Console.ReadLine();
                            Console.Write("Enter the new stock ");
                            int newStock = int.Parse(Console.ReadLine());
                            service.UpdateStock(sku,newStock);
                            break;
                        case 4:
                            List<Product> list = service.GetHigestPriorityProducts();
                            foreach(Product i in list)
                            {
                                Console.WriteLine($"SKU:{i.SKU}, Name: {i.Name}, Priority: {i.PriorityLevel}, Stock: {i.Stock}, Threshold: {i.Threshold}");
                            }
                            break;
                        case 5:
                            service.DisplayData();
                            break;
                        case 6:
                            Console.WriteLine("Thank You");
                            return;
                        default:
                            // TODO: Handle invalid choice
                            Console.WriteLine("Innvalid Choice");
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
