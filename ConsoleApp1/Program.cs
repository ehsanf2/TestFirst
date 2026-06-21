using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        ProductManager proManger =  new ProductManager();



        Console.WriteLine("1-Show all");
        Console.WriteLine("2-  Add product");
        Console.WriteLine("3- search name");
        Console.WriteLine("4- ordeby Price");

        string menuselcstion = Console.ReadLine();
        int menusel = 0;
        switch (menuselcstion)
        {
            case "1":
                foreach (Product product in proManger.GetAllProducts())
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
                newProd.Name = prodname.ToString();
                newProd.Price = Convert.ToDecimal(prodPrice);
                proManger.AddProduct(newProd);
                break;
            case "3":
                Console.WriteLine("Enter name");
                menuselcstion = Console.ReadLine();
                var result = proManger.SearchAll(menuselcstion.ToString());

                foreach (var item in result)
                {
                    Console.WriteLine($"Id = {item.Id} \n Name = {item.Name} \n Price = {item.Price}");
                }
                break;

            case "4":
                List<Product> orderedList = proManger.OrderbyPrice();
                foreach (Product item in orderedList)
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