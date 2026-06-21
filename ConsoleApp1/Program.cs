using System;
using System.Collections.Generic;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }


    public void ADDProduct(Product newPro)
    {

    }

    public void SearchProductName(string proName)
    {

    }

    
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        products.Add(new Product { Id = 1, Name = "dicast", Price = 150000 });
        products.Add(new Product { Id = 2, Name = "PU", Price = 20000 });
        products.Add(new Product { Id = 3, Name = "chodani", Price = 30000 });


        Console.WriteLine("1-Show all");
        Console.WriteLine("2-  Add product");
        Console.WriteLine("3- search name");
        Console.WriteLine("4- ordeby Price");

        string menuselcstion = Console.ReadLine();
        int menusel = 0;
        switch (menuselcstion)
        {
            case "1":
                foreach (Product product in products)
                {
                    Console.WriteLine($"Id = {product.Id} \n Name = {product.Name} \n Price = {product.Price}");
                }
                break;
            case "2":
                Console.WriteLine("Enter name");
                var prodname = Console.ReadLine();
                Console.WriteLine("Enter Price");
                var prodPrice =  Console.ReadLine();

                Product newProd = new Product();
                newProd.Id = 5;
                newProd.Name = prodname.ToString();
                newProd.Price = Convert.ToDecimal(prodPrice);
                products.Add(newProd);
                break;
            case "3":
                Console.WriteLine("Enter name");
                menuselcstion = Console.ReadLine();
                var result = products.Where(p=>p.Name.Contains(menuselcstion.ToString()));
                foreach (var item in result)
                {
                    Console.WriteLine($"Id = {item.Id} \n Name = {item.Name} \n Price = {item.Price}");
                }
                break;

            case "4":
                var priceOrder = products.OrderBy(p => p.Price);
                foreach (var item in priceOrder)
                {
                    Console.WriteLine($"Id = {item.Id} \n Name = {item.Name} \n Price = {item.Price}");
                }
                break;
        
        default:
                break;
        }


        //foreach (var pros in expensiveprods)
        //{
        //    Console.WriteLine($"Id:{pros.Id},Name:{pros.Name},Price:{pros.Price}");
        //}
    }

}