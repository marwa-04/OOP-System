using System;
using System.Collections.Generic;

class Stock
{
    public List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine("Product added.");
    }

    public void ShowProducts()
    {
        Console.WriteLine("\nStock List:");
        foreach (var p in products)
        {
            Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Price: {p.Price}, Quantity: {p.Quantity}");
        }
    }
}
