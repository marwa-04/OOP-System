class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public static Product operator +(Product p, int quantity)
    {
        p.Quantity += quantity;
        return p;
    }

    public static Product operator -(Product p, int quantity)
    {
        if (p.Quantity >= quantity)
            p.Quantity -= quantity;
        else
            Console.WriteLine("Insufficient stock!");
        return p;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Price: {Price:C}, Quantity: {Quantity}";
    }
}
