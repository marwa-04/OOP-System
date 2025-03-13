class OrderItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public decimal SalePrice { get; set; }

    public static OrderItem operator ++(OrderItem item)
    {
        item.Quantity++;
        return item;
    }

    public static OrderItem operator --(OrderItem item)
    {
        if (item.Quantity > 0) item.Quantity--;
        return item;
    }

    public override string ToString()
    {
        return $"{Product.Name} - {Quantity} x {SalePrice:C}";
    }
}
