using System;
using System.Collections.Generic;
using System.Linq;


namespace SalesReport
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }

    class SalesByCity
    {
        public string Town { get; set; }
        public decimal totalSales { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Sale[] allSales = ReadSales();
            List<SalesByCity> citySales = CalcSalesByCity(allSales);
            Console.WriteLine(string.Join(Environment.NewLine, citySales.OrderBy(s=>s.Town).Select(s=>s.Town + " -> " + $"{s.totalSales:f2}")));
        }

        static List<SalesByCity> CalcSalesByCity(Sale[] allSales)
        {
            Dictionary<string, decimal> totalSale = new Dictionary<string, decimal>();
            for(int i=0; i<allSales.Length; i++)
            {
                if (!totalSale.ContainsKey(allSales[i].Town))
                {
                    totalSale[allSales[i].Town] = 0;
                }
                totalSale[allSales[i].Town] += allSales[i].Quantity * allSales[i].Price;
            }

            return totalSale.Select(s => new SalesByCity { Town = s.Key, totalSales = s.Value }).ToList();
        }

        static Sale[] ReadSales()
        {
            int cycles = int.Parse(Console.ReadLine());
            Sale[] currentSales = new Sale[cycles];
            for (int i=0; i<cycles; i++)
            {
                var inputSale = Console.ReadLine().Split(' ');
                currentSales[i] = new Sale
                {
                    Town = inputSale[0],
                    Product = inputSale[1],
                    Price = decimal.Parse(inputSale[2]),
                    Quantity = decimal.Parse(inputSale[3])
                };
            }

            return currentSales;
        }
    }
}
