// using System;
// using System.Text;
// using System.Linq;
// using System.Collections.Generic;

// public class Product
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public decimal Price { get; set; }
//     public int Stock { get; set; }

//     public Product(int id, string name, decimal price, int stock)
//     {
//         if (stock < 0)
//             throw new InvalidOperationException("Stock cannot be negative.");

//         Id = id;
//         Name = name;
//         Price = price;
//         Stock = stock;
//     }

//     public bool PlaceOrder(int quantity)
//     {
//         if (quantity <= 0)
//             throw new InvalidOperationException("Quantity must be positive.");

//         if (Stock < quantity)
//             throw new OutOfStockException("Insufficient stock.");

//         Stock -= quantity;
//         return true;
//     }

//     public override string ToString()
//     {
//         return $"Product Id: {Id}, Name: {Name}, Price: {Price}, Stock: {Stock}";
//     }
// }

// public class Customer
// {
//     public int CustomerId { get; set; }
//     public string Name { get; set; }
//     public string Email { get; set; }
//     public bool IsBlackListed { get; set; }
//     public decimal TotalSpent { get; set; }

//     public override string ToString()
//     {
//         return $"Customer Id: {CustomerId}, Name: {Name}, Email: {Email}, Blacklisted: {IsBlackListed}, TotalSpent: {TotalSpent}";
//     }
// }

// public class Order
// {
//     public int OrderId { get; set; }
//     public Customer CustomerObject { get; set; }
//     public List<OrderItem> Items { get; set; } = new List<OrderItem>();
//     public DateTime OrderDate { get; set; }
//     public OrderStatus Status { get; set; }
//     public decimal TotalAmount { get; set; }
// }

// public class OrderItem
// {
//     public Product ProductObject { get; set; }
//     public int Quantity { get; set; }

//     public decimal GetTotalPrice()
//     {
//         return ProductObject.Price * Quantity;
//     }
// }

// public enum OrderStatus
// {
//     Pending,
//     Processing,
//     Shipped,
//     Delivered,
//     Cancelled
// }

// public class OutOfStockException : Exception
// {
//     public OutOfStockException(string message) : base(message) { }
// }

// public class OrderAlreadyShippedException : Exception
// {
//     public OrderAlreadyShippedException(string message) : base(message) { }
// }

// public class CustomerBlacklistedException : Exception
// {
//     public CustomerBlacklistedException(string message) : base(message) { }
// }

// public class UtilityClass
// {
//     List<Product> products = new List<Product>();
//     List<Customer> customers = new List<Customer>();
//     List<Order> orders = new List<Order>();
//     Dictionary<int, Product> productDictionary = new Dictionary<int, Product>();

//     int orderCounter = 1;

//     // Add Product
//     public bool AddProduct(Product product)
//     {
//         if (product == null)
//         {
//             Console.WriteLine("Product cannot be null.");
//             return false;
//         }

//         if (products.Any(p => p.Id == product.Id))
//         {
//             Console.WriteLine("Product already exists.");
//             return false;
//         }

//         products.Add(product);
//         productDictionary.Add(product.Id, product);

//         return true;
//     }

//     // Update Stock
//     public bool UpdateProductStock(int productId, int newStock)
//     {
//         Product product = products.FirstOrDefault(p => p.Id == productId);

//         if (product == null)
//         {
//             Console.WriteLine("Product not found.");
//             return false;
//         }

//         if (newStock < 0)
//         {
//             Console.WriteLine("Stock cannot be negative.");
//             return false;
//         }

//         product.Stock = newStock;
//         return true;
//     }

//     public void ViewAllProducts()
//     {
//         foreach (var product in products)
//             Console.WriteLine(product);
//     }

//     // Add Customer
//     public bool AddCustomer(Customer customer)
//     {
//         if (customer == null)
//         {
//             Console.WriteLine("Customer cannot be null.");
//             return false;
//         }

//         if (customers.Any(c => c.CustomerId == customer.CustomerId))
//         {
//             Console.WriteLine("Customer already exists.");
//             return false;
//         }

//         customers.Add(customer);
//         return true;
//     }

//     public bool BlackListCustomer(int customerId)
//     {
//         var customer = customers.FirstOrDefault(c => c.CustomerId == customerId);

//         if (customer == null)
//         {
//             Console.WriteLine("Customer not found.");
//             return false;
//         }

//         customer.IsBlackListed = true;
//         return true;
//     }

//     public void ViewAllCustomers()
//     {
//         foreach (var customer in customers)
//             Console.WriteLine(customer);
//     }

//     // PLACE ORDER
//     public bool PlaceOrder(int customerId, int productId, int quantity)
//     {
//         Product product = productDictionary.ContainsKey(productId)
//             ? productDictionary[productId]
//             : null;

//         Customer customer = customers.FirstOrDefault(c => c.CustomerId == customerId);

//         if (product == null)
//         {
//             Console.WriteLine("Product not found.");
//             return false;
//         }

//         if (customer == null)
//         {
//             Console.WriteLine("Customer not found.");
//             return false;
//         }

//         if (customer.IsBlackListed)
//             throw new CustomerBlacklistedException("Customer is blacklisted.");

//         product.PlaceOrder(quantity);

//         OrderItem item = new OrderItem
//         {
//             ProductObject = product,
//             Quantity = quantity
//         };

//         Order order = new Order
//         {
//             OrderId = orderCounter++,
//             CustomerObject = customer,
//             OrderDate = DateTime.Now,
//             Status = OrderStatus.Pending
//         };

//         order.Items.Add(item);

//         order.TotalAmount = item.GetTotalPrice();

//         orders.Add(order);

//         customer.TotalSpent += order.TotalAmount;

//         Console.WriteLine("Order placed successfully.");

//         return true;
//     }

//     // CANCEL ORDER
//     public bool CancelOrder(int orderId)
//     {
//         var order = orders.FirstOrDefault(o => o.OrderId == orderId);

//         if (order == null)
//         {
//             Console.WriteLine("Order not found.");
//             return false;
//         }

//         if (order.Status == OrderStatus.Shipped || order.Status == OrderStatus.Delivered)
//             throw new OrderAlreadyShippedException("Cannot cancel shipped order.");

//         foreach (var item in order.Items)
//             item.ProductObject.Stock += item.Quantity;

//         order.Status = OrderStatus.Cancelled;

//         Console.WriteLine("Order cancelled.");

//         return true;
//     }

//     // VIEW ORDER DETAILS
//     public void ViewOrderDetails(int orderId)
//     {
//         var order = orders.FirstOrDefault(o => o.OrderId == orderId);

//         if (order == null)
//         {
//             Console.WriteLine("Order not found.");
//             return;
//         }

//         Console.WriteLine($"Order Id: {order.OrderId}");
//         Console.WriteLine($"Customer: {order.CustomerObject.Name}");
//         Console.WriteLine($"Date: {order.OrderDate}");
//         Console.WriteLine($"Status: {order.Status}");

//         foreach (var item in order.Items)
//         {
//             Console.WriteLine($"Product: {item.ProductObject.Name}, Quantity: {item.Quantity}, Total: {item.GetTotalPrice()}");
//         }

//         Console.WriteLine($"Total Amount: {order.TotalAmount}");
//     }

//     // UPDATE ORDER STATUS
//     public bool UpdateOrderStatus(int orderId, OrderStatus newStatus)
//     {
//         var order = orders.FirstOrDefault(o => o.OrderId == orderId);

//         if (order == null)
//         {
//             Console.WriteLine("Order not found.");
//             return false;
//         }

//         order.Status = newStatus;

//         Console.WriteLine("Order status updated.");

//         return true;
//     }

//     // LINQ REPORTS

//     public void GetRecentOrders()
//     {
//         var recent = orders.Where(o => o.OrderDate >= DateTime.Now.AddDays(-7));

//         foreach (var order in recent)
//             Console.WriteLine($"OrderId: {order.OrderId}, Customer: {order.CustomerObject.Name}, Total: {order.TotalAmount}");
//     }

//     public void GetTotalRevenue()
//     {
//         var revenue = orders.Sum(o => o.TotalAmount);
//         Console.WriteLine($"Total Revenue: {revenue}");
//     }

//     public void GetMostSoldProduct()
//     {
//         var result = orders
//             .SelectMany(o => o.Items)
//             .GroupBy(i => i.ProductObject.Name)
//             .Select(g => new { Name = g.Key, Quantity = g.Sum(i => i.Quantity) })
//             .OrderByDescending(g => g.Quantity)
//             .FirstOrDefault();

//         Console.WriteLine($"Most sold product: {result?.Name}");
//     }

//     public void GetTopCustomers()
//     {
//         var top = customers.OrderByDescending(c => c.TotalSpent).Take(5);

//         foreach (var c in top)
//             Console.WriteLine($"{c.Name} spent {c.TotalSpent}");
//     }

//     public void GetLowStockProducts()
//     {
//         var low = products.Where(p => p.Stock < 10);

//         foreach (var p in low)
//             Console.WriteLine(p);
//     }
// }

// public class Program
// {
//     static UtilityClass system = new UtilityClass();

//     public static void Main(string[] args)
//     {
//         bool exit = false;

//         while (!exit)
//         {
//             Console.WriteLine("\n===== E-Commerce Order Management =====");
//             Console.WriteLine("1. Add Product");
//             Console.WriteLine("2. Add Customer");
//             Console.WriteLine("3. Place Order");
//             Console.WriteLine("4. Cancel Order");
//             Console.WriteLine("5. View Order Details");
//             Console.WriteLine("6. Update Order Status");
//             Console.WriteLine("7. View All Products");
//             Console.WriteLine("8. View All Customers");
//             Console.WriteLine("9. Total Revenue");
//             Console.WriteLine("10. Most Sold Product");
//             Console.WriteLine("11. Exit");

//             Console.Write("Enter choice: ");
//             int choice = int.Parse(Console.ReadLine());

//             try
//             {
//                 switch (choice)
//                 {
//                     case 1:
//                         AddProductUI();
//                         break;

//                     case 2:
//                         AddCustomerUI();
//                         break;

//                     case 3:
//                         PlaceOrderUI();
//                         break;

//                     case 4:
//                         CancelOrderUI();
//                         break;

//                     case 5:
//                         ViewOrderUI();
//                         break;

//                     case 6:
//                         UpdateOrderStatusUI();
//                         break;

//                     case 7:
//                         system.ViewAllProducts();
//                         break;

//                     case 8:
//                         system.ViewAllCustomers();
//                         break;

//                     case 9:
//                         system.GetTotalRevenue();
//                         break;

//                     case 10:
//                         system.GetMostSoldProduct();
//                         break;

//                     case 11:
//                         exit = true;
//                         break;

//                     default:
//                         Console.WriteLine("Invalid choice.");
//                         break;
//                 }
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"Error: {ex.Message}");
//             }
//         }
//     }

//     static void AddProductUI()
//     {
//         Console.Write("Enter Product Id: ");
//         int id = int.Parse(Console.ReadLine());

//         Console.Write("Enter Name: ");
//         string name = Console.ReadLine();

//         Console.Write("Enter Price: ");
//         decimal price = decimal.Parse(Console.ReadLine());

//         Console.Write("Enter Stock: ");
//         int stock = int.Parse(Console.ReadLine());

//         Product p = new Product(id, name, price, stock);

//         system.AddProduct(p);
//     }

//     static void AddCustomerUI()
//     {
//         Console.Write("Enter Customer Id: ");
//         int id = int.Parse(Console.ReadLine());

//         Console.Write("Enter Name: ");
//         string name = Console.ReadLine();

//         Console.Write("Enter Email: ");
//         string email = Console.ReadLine();

//         Customer c = new Customer
//         {
//             CustomerId = id,
//             Name = name,
//             Email = email
//         };

//         system.AddCustomer(c);
//     }

//     static void PlaceOrderUI()
//     {
//         Console.Write("Enter Customer Id: ");
//         int customerId = int.Parse(Console.ReadLine());

//         Console.Write("Enter Product Id: ");
//         int productId = int.Parse(Console.ReadLine());

//         Console.Write("Enter Quantity: ");
//         int quantity = int.Parse(Console.ReadLine());

//         system.PlaceOrder(customerId, productId, quantity);
//     }

//     static void CancelOrderUI()
//     {
//         Console.Write("Enter Order Id: ");
//         int orderId = int.Parse(Console.ReadLine());

//         system.CancelOrder(orderId);
//     }

//     static void ViewOrderUI()
//     {
//         Console.Write("Enter Order Id: ");
//         int orderId = int.Parse(Console.ReadLine());

//         system.ViewOrderDetails(orderId);
//     }

//     static void UpdateOrderStatusUI()
//     {
//         Console.Write("Enter Order Id: ");
//         int orderId = int.Parse(Console.ReadLine());

//         Console.WriteLine("Select Status:");
//         Console.WriteLine("0. Pending");
//         Console.WriteLine("1. Processing");
//         Console.WriteLine("2. Shipped");
//         Console.WriteLine("3. Delivered");
//         Console.WriteLine("4. Cancelled");

//         int status = int.Parse(Console.ReadLine());

//         system.UpdateOrderStatus(orderId, (OrderStatus)status);
//     }
// }
