using Modulo10.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Modulo10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProduct = new List<Product>();

            Console.Write("Enter the number of products: ");
            int values = int.Parse(Console.ReadLine());

            for (int i = 1; i <= values; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (type == 'c')
                {
                    Product product = new Product(name, price);
                    listProduct.Add(product);
                } 
                else if(type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    Product product = new UsedProduct(name, price, date);
                    listProduct.Add(product);
                }
                else if(type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine());

                    Product product = new ImportedProduct(name, price, customFee);
                    listProduct.Add(product);
                }
            }

            Console.WriteLine("PRICE TAGS:");
            foreach (var product in listProduct)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
