using System;
using System.Collections.Generic;
using System.Linq;

class Stock
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine("Product added successfully.");
    }

    public void EditProduct(int productId, string name, decimal price, int quantity)
    {
        var product = products.FirstOrDefault(p => p.Id == productId);
        if (product != null)
        {
            product.Name = name;
            product.Price = price;
            product.Quantity = quantity;
            Console.WriteLine("Product updated successfully.");
        }
        else
            Console.WriteLine("Product not found.");
    }

    public void DeleteProduct(int productId)
    {
        var product = products.FirstOrDefault(p => p.Id == productId);
        if (product != null)
        {
            products.Remove(product);
            Console.WriteLine("Product deleted successfully.");
        }
        else
            Console.WriteLine("Product not found.");
    }

    public Product SearchProduct(int productId)
    {
        return products.FirstOrDefault(p => p.Id == productId);
    }

    public int GetProductCount() => products.Count;

    public void PrintStock()
    {
        Console.WriteLine("Stock List:");
        foreach (var product in products)
            Console.WriteLine(product);
    }
}
