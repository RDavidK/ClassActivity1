using System;
using System.Collections.Generic;

namespace prjInventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product { id = 1, name = "Pencil", quantity = 10, price = 2.50 },
                new Product { id = 2, name = "Pen", quantity = 50, price = 3.40 },
                new Product { id = 3, name = "Eraser", quantity = 3, price = 4.90 }
            };//adding custom types to a list

            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.name}\nIn stock: {product.quantity}\nPrice: R{product.price}\n");
            }

            // Using extension method for total value
            double total = products.TotalValue();
            Console.WriteLine("\nTotal value of all products: R" + total);

            //extension stock filtering
            var lowStock = products.LowInStock(5);
            Console.WriteLine("\nLow Stock Products:");
            foreach (var product in lowStock)
            {
                Console.WriteLine($"{product.name} - Quantity: {product.quantity}");
            }

            // LINQ query selecting only name and price into an anonymous type
            var nameAndPrice = from p in products select new { p.name, p.price };

            Console.WriteLine("\nProduct Name and Price:");
            foreach (var item in nameAndPrice)
            {
                Console.WriteLine($"{item.name} - R{item.price}");
            }
        }
    }
}

/*
 * References

adjan, 2023. List with a custom type. (Version 2.0) [Source Code] 
Available at: https://stackoverflow.com/questions/48023596/list-with-a-custom-type
[Accessed 10 August 2025].

tutorialsteacher, 2020. C# - Anonymous Type. (Version 2.0) [Source Code]  
Available at: https://www.tutorialsteacher.com/csharp/csharp-anonymous-type
[Accessed 10 August 2025].

tutorialsteacher, 2025. C# - Extension Method. (Version 2.0) [Source Code]  
Available at: https://www.tutorialsteacher.com/csharp/csharp-extension-method
[Accessed 10 August 2025].

 */