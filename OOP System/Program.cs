class Program
{
    static Stock stock = new Stock();
    static List<Customer> customers = new List<Customer>();
    static List<Order> orders = new List<Order>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSales Order Application:");
            Console.WriteLine("1. Add/Edit/Delete Customer");
            Console.WriteLine("2. Add/Edit/Delete Product");
            Console.WriteLine("3. Add Order");
            Console.WriteLine("4. Update Order Status");
            Console.WriteLine("5. Pay Order");
            Console.WriteLine("6. Print Customers");
            Console.WriteLine("7. Print Stock");
            Console.WriteLine("8. Print Transactions");
            Console.WriteLine("9. Exit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter customer name: ");
                    customers.Add(new Customer { Id = customers.Count + 1, Name = Console.ReadLine() });
                    Console.WriteLine("Customer added.");
                    break;
                case "2":
                    Console.Write("Enter product name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter price: ");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    stock.AddProduct(new Product { Id = stock.GetProductCount() + 1, Name = name, Price = price, Quantity = quantity });
                    break;
                case "3":
                    Order order = new Order();
                    Console.Write("Enter product ID: ");
                    int productId = int.Parse(Console.ReadLine());
                    Console.Write("Enter quantity: ");
                    int qty = int.Parse(Console.ReadLine());
                    Product product = stock.SearchProduct(productId);
                    if (product != null)
                    {
                        order.AddItem(new OrderItem { Product = product, Quantity = qty, SalePrice = product.Price });
                        orders.Add(order);
                        Console.WriteLine("Order added.");
                    }
                    break;
                case "9":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
