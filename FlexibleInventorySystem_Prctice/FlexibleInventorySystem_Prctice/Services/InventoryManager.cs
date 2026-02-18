using FlexibleInventorySystem_Practice.Interfaces;
using FlexibleInventorySystem_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleInventorySystem_Practice.Services
{  
    public class InventoryManager : IInventoryOperations, IReportGenerator
    {
        private List<Product> _products;
        private object _lockObject = new object();

        public InventoryManager()
        {
            _products = new List<Product>();
        }

        public bool AddProduct(Product product)
        {
            if (!_products.Any(p => p.Id == product.Id) && product!=null)
            {
                _products.Add(product);
                return true;
            }
            return false;

        }

        public Product FindProduct(string productId)
        {
            return _products.FirstOrDefault(p => p.Id == productId);

        }

        public string GenerateCategorySummary()
        {
            string result=string.Empty;
            var groupByCatagory = _products.GroupBy(p => p.GetType()).Select(g =>new {Type = g.Key.Name , count = g.Count(), TotalValue = g.Sum(p => p.Price)});
            foreach(var group in groupByCatagory)
            {
                result += $"{group.Type}: {group.count} items - Total Value: {group.TotalValue:C}\n";
            }
            return result;

        }

        public string GenerateExpiryReport(int daysThreshold)
        {   
            string result = string.Empty;
            var report = _products.OfType<GroceryProduct>().Where(p => (p.ExpiryDate-DateTime.Now).Days<=daysThreshold);
            foreach(var i in report)
            {
                result+= $"{i.Id} {i.Name}\n";
            }
            return result;

        }

        public string GenerateInventoryReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("================================");
            sb.AppendLine("\nINVENTORY REPORT\n");
            sb.AppendLine("================================");
            sb.AppendLine($"Total Products: {_products.Count}");
            sb.AppendLine($"Total Value: {_products.Sum(p => p.CalculateValue())}");
            return sb.ToString();

        }

        public string GenerateValueReport()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"Most valuble product: {_products.OrderByDescending(p => p.Price).FirstOrDefault()?.Name}");
            sb.AppendLine($"Least valuble product: {_products.OrderBy(p => p.Price).FirstOrDefault()?.Name}");
            decimal averagePrice = _products.Average(p => p.Price);
            sb.AppendLine($"Average Price: {averagePrice}");
            sb.AppendLine($"Median price: {_products.OrderBy(p => p.Price).Skip(_products.Count/2).FirstOrDefault()?.Price}");
            sb.AppendLine($"Products above average price: {string.Join(", ",_products.Where(p => p.Price>averagePrice).Select(p => p.Name))}");

            return sb.ToString();


        }

        public List<Product> GetLowStockProducts(int threshold)
        {
            List<Product> products = _products.Where(p => p.Quantity < threshold).ToList();
            return products;
        }

        public List<Product> GetProductsByCategory(string category)
        {
            IEnumerable<Product> result;
            if (category.Equals("Groceries",StringComparison.OrdinalIgnoreCase))
            {
                result = _products.OfType<GroceryProduct>();
            }
            else if (category.Equals("Electronics", StringComparison.OrdinalIgnoreCase))
            {
                result = _products.OfType<ElectronicProduct>();
            }
            else if(category.Equals("Clothing", StringComparison.OrdinalIgnoreCase))
            {
                result = _products.OfType<ClothingProduct>();
            }
            else
            {
                Console.WriteLine("Invalid category");
                result = new List<Product>();
            }


            return result.ToList();

        }

        public decimal GetTotalInventoryValue()
        {
            decimal result = _products.Sum(p => p.CalculateValue());
            return result;

        }

        public bool RemoveProduct(string productId)
        {

            Product product = _products.FirstOrDefault(p => p.Id == productId);
            if(product == null)
            {
                Console.WriteLine("Product id not found in the list.");
                return false;
            }
            _products.Remove(product);
            return true;

        }

        // Implement all interface methods here

        // Additional methods for bonus features
        public IEnumerable<Product> SearchProducts(Func<Product, bool> predicate)
        {
            return _products.Where(predicate);
        }

        public bool UpdateQuantity(string productId, int newQuantity)
        {
            Product product = _products.FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                Console.WriteLine("Product id not found in list.");
                return false;
            }
            product.Quantity = newQuantity;
            return true;
        }

        
    }    
}
