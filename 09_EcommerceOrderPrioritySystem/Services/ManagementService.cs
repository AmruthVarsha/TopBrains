using System.Collections.Generic;
using Domain;
using Exceptions;

namespace Services
{
    public class ManagementService
    {
        private SortedDictionary<int, List<Product>> _data
            = new SortedDictionary<int, List<Product>>();

        public void AddProduct(int key, Product entity)
        {

            // TODO: Validate entity
            if (!entity.Validate())
            {
                throw new InvalidProductException("Product does not have valid information");
            }
            bool productExists = false;
            foreach(KeyValuePair<int,List<Product>> list in _data)
            {
                productExists = list.Value.Any(p => p.SKU==entity.SKU);
                if (productExists)
                {
                    break;
                }
            }
            if (productExists)
            {   
                throw new DuplicateSKUException("SKU already exists in the products");
            }
            // TODO: Handle duplicate entries
            // TODO: Add entity to SortedDictionary
            if(entity.Stock < entity.Threshold)
            {
                throw new LowStockException("The stack is lower than threshold amount");
            }
            if (!_data.ContainsKey(key))
            {
                _data[key] = new List<Product>();
            }

            _data[key].Add(entity);

            return;
        }

        public void RemoveProduct(string sku)
        {
            // TODO: Update entity logic
            bool found = false;
            int key=0;
            Product product=null;
            foreach(KeyValuePair<int,List<Product>> list in _data)
            {
                found = list.Value.Any(p => p.SKU == sku);
                if (found)
                {
                    product = list.Value.First(p => p.SKU == sku);
                    key = list.Key;
                    break;  
                }
            }
            if (found)
            {
                _data[key].Remove(product);
                return;
            }
            throw new InvalidProductException("SKU not found");
        }

        public void UpdateStock(string sku,int newStock)
        {
            // TODO: Remove entity logic
            bool found = false;
            Product product=null;
            foreach(KeyValuePair<int,List<Product>> list in _data)
            {
                found = list.Value.Any(p => p.SKU == sku);
                if (found)
                {
                    product = list.Value.First(p => p.SKU == sku);
                    break;  
                }
            }
            if (found)
            {
                if (newStock < product.Threshold)
                {
                    throw new LowStockException("Stock is below threshold");
                }

                product.Stock = newStock;

                return;
            }
            throw new InvalidProductException("SKU not found");
        }

        public List<Product> GetHigestPriorityProducts()
        {
            foreach(var pair in _data)
            {
                return pair.Value;
            }
            return new List<Product>();
        }

        public void DisplayData()
        {
            foreach(KeyValuePair<int,List<Product>> dict in _data)
            {
                {
                    Console.Write(dict.Key+": ");
                    foreach(Product i in dict.Value)
                        {
                            Console.WriteLine($"SKU:{i.SKU}, Name: {i.Name}, Priority: {i.PriorityLevel}, Stock: {i.Stock}, Threshold: {i.Threshold}");
                        }
                }
            }
            return;
        }
    }
}
