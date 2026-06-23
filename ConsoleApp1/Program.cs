using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        ProductManager proManger = new ProductManager();



        Console.WriteLine("1-Show all");
        Console.WriteLine("2-  Add product");
        Console.WriteLine("3- search name");
        Console.WriteLine("4- ordeby Price");
        Console.WriteLine("5- Get By ID");
        Console.WriteLine("6- Delete Product");
        Console.WriteLine("7- Edite Product");

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
                var prodPrice = Console.ReadLine();

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

            case "5":
                Console.WriteLine("Enter Id:");
                int id = Convert.ToInt32(Console.ReadLine());
                var searchedProduct = proManger.GetById(id);
                if (searchedProduct != null)
                {
                    Console.WriteLine($"Id = {searchedProduct.Id} \n Name = {searchedProduct.Name} \n Price = {searchedProduct.Price}");
                }
                else
                {
                    Console.WriteLine($"This Id is not created");

                }
                break;
            case "6":
                Console.WriteLine("Enter Product ID:");

                id = Convert.ToInt32(Console.ReadLine());
                var selDeleteProduct = proManger.GetById(id);
                if (selDeleteProduct != null)
                {
                    bool delResult = proManger.DeleteProduct(selDeleteProduct.Id);
                    if (delResult)
                        Console.WriteLine("Product deleted successfull!!");
                    else
                        Console.WriteLine("Product deleted has an error!!");

                }
                else
                    Console.WriteLine("Product Not found!");
                break;

            case "7":
                Console.WriteLine("Enter Product ID:");
                id = Convert.ToInt32(Console.ReadLine());
                var selEditProduct = proManger.GetById(id);

                if (selEditProduct != null)
                {
                    Console.WriteLine("Enter New Name:");
                    var newName = Console.ReadLine();

                    Console.WriteLine("Enter New Price:");
                    int newPrice = Convert.ToInt32(Console.ReadLine());
                    bool editResult = proManger.UpdateProduct(selEditProduct.Id, newName.ToString(), newPrice);
                    if (editResult)
                        Console.WriteLine("Product edit was successfull!!");
                    else
                        Console.WriteLine("Product edit has an error!!");


                }
                else
                    Console.WriteLine("Product Not Found!");


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