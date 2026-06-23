using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;


public class ProductManager
{
    private string filePath = "Products.json";
    private List<Product> Products = new();


    public ProductManager()
    {
        LoadProducts();
    }

    private void LoadProducts()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            var readPros = JsonSerializer.Deserialize<List<Product>>(json);
            if (readPros != null)
                Products = readPros;
        }
    }

    private void SaveProducts()
    {
        string json =
            JsonSerializer.Serialize(Products,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });
        File.WriteAllText(filePath, json);
    }
    
    public bool DeleteProduct(int Id)
    {
        var product = Products.FirstOrDefault(p => p.Id == Id);

        if (product == null)
            return false;

        else
        {
            Products.Remove(product);

            SaveProducts();
            return true;
        }
    }

    public bool UpdateProduct(int id, string newName , decimal newPrice)
    {
        var product = Products.FirstOrDefault (p => p.Id == id);

        if(product == null) 
            return false;
        else
        {
            product.Name = newName;
            product.Price = newPrice;

            SaveProducts();
            return true;
        }
    }
    public List<Product> GetAllProducts()
    {
        return Products;
    }

    public void AddProduct(Product product)
    {
        product.Id = Products.Count + 1;
        Products.Add(product);
        SaveProducts();
    }

    public List<Product> SearchAll(string name)
    {
        return Products.Where(p => p.Name.Contains(name)).ToList();

    }

    public List<Product> OrderbyPrice()
    {
        return Products.OrderBy(p => p.Price).ToList();
    }


    public Product? GetById(int id)
    {
        return Products.FirstOrDefault(p => p.Id == id);
    }
}
