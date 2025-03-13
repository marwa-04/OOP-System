class Program
{
    static void Main()
    {
        Stock stock = new Stock();
        List<Customer> customers = new List<Customer>();
        List<Order> orders = new List<Order>();

        while (true)
        {
            Console.WriteLine("\n1. Add Product");
            Console.WriteLine("2. Show Stock");
            Console.WriteLine("3. Add Order");
            Console.WriteLine("4. Show Orders");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter Product ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter Product Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Price: ");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.Write("Enter Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(id, name, price, quantity);
                stock.AddProduct(product);
            }
            else if (choice == "2")
            {
                stock.ShowProducts();
            }
            else if (choice == "3")
            {
                Console.Write("Enter Order Number: ");
                int orderNum = int.Parse(Console.ReadLine());
                Order order = new Order(orderNum);

                Console.Write("Enter Product ID: ");
                int productId = int.Parse(Console.ReadLine());

                Product foundProduct = stock.products.Find(p => p.Id == productId);
                if (foundProduct != null)
                {
                    Console.Write("Enter Quantity: ");
                    int qty = int.Parse(Console.ReadLine());

                    OrderItem item = new OrderItem(foundProduct, qty);
                    order.AddItem(item);
                    orders.Add(order);
                    Console.WriteLine("Order added.");
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }
            else if (choice == "4")
            {
                foreach (var order in orders)
                {
                    order.ShowOrder();
                }
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
