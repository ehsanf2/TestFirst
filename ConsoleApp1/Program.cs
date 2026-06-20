using System;
using System.Collections.Generic;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        products.Add(new Product { Id = 1, Name = "dicast", Price = 150000 });
        products.Add(new Product { Id = 2, Name = "PU", Price = 20000 });
        products.Add(new Product { Id = 3, Name = "chodani", Price = 30000 });


        var expensiveprods = products.Where(p => p.Price > 30000);

        foreach (var pros in expensiveprods)
        {
            Console.WriteLine($"Id:{pros.Id},Name:{pros.Name},Price:{pros.Price}");
        }
    }

}