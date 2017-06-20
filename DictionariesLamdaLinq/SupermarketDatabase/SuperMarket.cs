using System;
using System.Collections.Generic;
using System.Linq;

namespace SupermarketDatabase
{
    class SuperMarket
    {
        static void Main()
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            while (true)
            {
                string[] currentProduct = Console.ReadLine().Split(' ').ToArray();
                var productName = currentProduct[0];
                if (productName == "stocked")
                {
                    break;
                }

                if (!products.ContainsKey(productName))
                {
                    products[productName] = new double[] { 0.0, 0.0 };
                }

                var productPrice = double.Parse(currentProduct[1]);
                var productQuantity = double.Parse(currentProduct[2]);

                products[productName][0] = productPrice;
                products[productName][1] += productQuantity;
            }
            var grandTotal = products.Sum(d => d.Value[0] * d.Value[1]);

            Console.Write(string.Join("", products.Select(d => d.Key + ": $" + string.Format("{0:f2}", d.Value[0]) + " * " + d.Value[1] + " = $" + string.Format("{0:f2}", d.Value[0] * d.Value[1]) + Environment.NewLine)));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}
