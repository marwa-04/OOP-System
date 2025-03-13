class Order
{
    private static Random random = new Random();
    public int OrderNumber { get; private set; }
    public DateTime OrderDate { get; private set; }
    public decimal TotalAmount { get; private set; }
    public string Status { get; private set; }
    public List<OrderItem> Items { get; private set; }

    public Order()
    {
        OrderNumber = random.Next(1, 100000);
        OrderDate = DateTime.Now;
        Status = "New";
        Items = new List<OrderItem>();
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
        TotalAmount += item.SalePrice * item.Quantity;
    }

    public void UpdateOrderStatus(string newStatus)
    {
        if (new List<string> { "New", "Hold", "Paid", "Canceled" }.Contains(newStatus))
        {
            Status = newStatus;
            Console.WriteLine("Order status updated.");
        }
        else
            Console.WriteLine("Invalid status.");
    }

    public override string ToString()
    {
        return $"Order No: {OrderNumber}, Date: {OrderDate}, Status: {Status}, Total: {TotalAmount:C}";
    }
}
