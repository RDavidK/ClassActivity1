using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace prjInventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var products = new List<Product>();

            // Add elements to the list
            products.Add(new Product { id = 1, name = "Pencil", quantity = 10, price = 2.50 });
            products.Add(new Product { id = 2, name = "Pen", quantity = 50, price = 3.40});
            products.Add(new Product { id = 3, name = "Eraser", quantity = 80, price = 4.90 });

            foreach (var product in products)
            {
                Console.WriteLine("Product: " + product.name + "\nIn stock: " + product.quantity + "\nPrice: R" + product.price + "\n\n");
            }
        }

        public static double Sum(List<Product> products)
        {


            return products.Sum(p => p.id);
            
        }
    }
}
