using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    public static class ProductExtensions
    {
        //extension sum
        public static double TotalValue(this List<Product> products)
        {
            double sum = 0;
            foreach (var product in products)
            {
                sum += product.price * product.quantity;
            }
            return sum;
        }

        //filters extension
        public static List<Product> LowInStock(this List<Product> products, int lowStock)
        {
            return products.Where(p => p.quantity < lowStock).ToList();
        }
    }
}

/*References
 * 
tutorialsteacher, 2025. C# - Extension Method. (Version 2.0) [Source Code]  
Available at: https://www.tutorialsteacher.com/csharp/csharp-extension-method
[Accessed 10 August 2025]
*/