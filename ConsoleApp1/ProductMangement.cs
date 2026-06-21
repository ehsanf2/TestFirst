using System;
using System.Collections.Generic;


public class ProductManager
{
    private List<Product> Products = new List<Product>();


    public ProductManager()
    {
        Products.Add(new Product { Id = 1, Name = "dicast", Price = 150000 });
        Products.Add(new Product { Id = 2, Name = "PU", Price = 20000 });
        Products.Add(new Product { Id = 3, Name = "chodani", Price = 30000 });

    }

    public List<Product> GetAllProducts()
    {
        return Products;
    }

    public void AddProduct(Product product)
    {
        product.Id = Products.Count + 1;
        Products.Add(product);
    }

    public List<Product> SearchAll(string name)
    {
        return Products.Where(p => p.Name.Contains(name)).ToList();

    }

    public List<Product> OrderbyPrice()
    {
        return Products.OrderBy(p => p.Price).ToList();
    }
}
