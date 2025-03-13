class Order
{
    public int OrderNumber;
    public List<OrderItem> Items = new List<OrderItem>();
    public string Status;

    public Order(int orderNumber)
    {
        OrderNumber = orderNumber;
        Status = "New";
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }

    public void ShowOrder()
    {
        Console.WriteLine($"\nOrder {OrderNumber}, Status: {Status}");
        foreach (var item in Items)
        {
            Console.WriteLine($"Product: {item.Product.Name}, Quantity: {item.Quantity}");
        }
    }
}
