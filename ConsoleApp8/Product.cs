﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    // create a class called product . 2 funtions with different parameters.
    // one takes in the name of the product and one takes in the name and price
    // and one takes in the name and price and quantity. 
    // name // product name : item 
    // name // product name : item + Price : 100 // + quantity : 1000
    // Totl = price * quantity 
    // call in main program 
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public double Total { get; set; }
        public bool Stock { get; set; }
        public void GetName(String name)
        {
            Console.WriteLine("Name of Product is = " + name);
        }

        public void SetPrice(double price, string name)
        {
            Console.WriteLine("Name of Product is = " + name + " Price of prduct is = " + price);
        }
        public void SetQuantity(double quantity, string name, double price, double total)
        {
            Total = price * quantity;
        }

        // Bonus : List to store multiple prducts 
        List<Product> products = new List<Product>();

        public void AddProducts(string name, double quantity, double price, double total, bool stock)
        {
            products.Add(new Product { Quantity = quantity, Name = name, Price = price, Total = total, Stock = stock });
        }

        public void GetProducts()
        {
            foreach (Product product in products)
            {

                Console.WriteLine("Product name is : " + product.Name + "   Product price : " + product.Price + "   Quantity is : " + product.Quantity + "  Total  is : " + product.Total + "   Product In stock = " + product.Stock);
            }
        }
        public void GetStock()
        {
            int instock = 0;
            int outofstock = 0;
            foreach (Product product in products)
            {
                if (product.Stock == true)
                {
                    instock++;
                }
                else if (product.Stock == false) {
                    {
                        outofstock++;
                    }
                }
            }
            Console.WriteLine($"Products in stock = {instock} " + $"Products out of stock = {outofstock}");
        }
    }
}
