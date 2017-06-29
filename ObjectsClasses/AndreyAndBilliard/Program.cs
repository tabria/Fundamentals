using System;
using System.Collections.Generic;
using System.Linq;


namespace AndreyAndBilliard
{

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> orders { get; set; }
        public decimal bill { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            AddProducts(products);
            List<Customer> clients = AddClients(products);
            PrintBill(clients);
        }

        static void PrintBill(List<Customer> clients)
        {
            foreach( var entry in clients.OrderBy(s=>s.Name))
            {
                Console.WriteLine(entry.Name);
                Console.WriteLine(string.Join(Environment.NewLine, entry.orders.Select(s=>$"-- {s.Key}" + " - " + s.Value).ToArray()));
                Console.WriteLine($"Bill: {entry.bill:f2}");
            }

            Console.WriteLine("Total bill: {0:f2}", clients.Sum(d => d.bill));
        }

        static List<Customer> AddClients(Dictionary<string, decimal> products)
        {
            List<Customer> allCustomers = new List<Customer>();
            
            while (true)
            {
                string[] currentClient = Console.ReadLine().Split('-', ',').ToArray();
                string clientName = currentClient[0];
                if (clientName == "end of clients")
                {
                    break;
                }

                string productName = currentClient[1];
                if (!products.ContainsKey(productName))
                {
                    continue;
                }

                int productQuantity = int.Parse(currentClient[2]);
                bool isCustomerExist = isOrderExistingCustomer(allCustomers, clientName, productName, productQuantity, products[productName]);

                if (!isCustomerExist)
                {
                    Customer client = new Customer();
                    client.Name = clientName;
                    client.orders = new Dictionary<string, int>();
                    client.orders[productName] = productQuantity;
                    client.bill = productQuantity * products[productName];
                    allCustomers.Add(client);
                }
            }

            return allCustomers;
        }

        static bool isOrderExistingCustomer(List<Customer> allCustomers, string clientName, string productName, int productQuantity, decimal productPrice)
        {
            bool isExist = false;
            foreach (var clientItem in allCustomers.Where(s => s.Name == clientName))
            {
                if (!clientItem.orders.ContainsKey(productName))
                {
                    clientItem.orders[productName] = 0;
                }
                clientItem.orders[productName] += productQuantity;
                clientItem.bill += productQuantity * productPrice;
                isExist = true;
                break;
            }

            return isExist;
        }

        static bool isExistingCustomer(List<Customer> allCustomers, string clientName)
        {
            return allCustomers.Any(s=>s.Name == clientName);
        }

        static void AddProducts(Dictionary<string, decimal> products)
        {
            int cycles = int.Parse(Console.ReadLine());
            for(int i=0; i<cycles; i++)
            {
                string[] currentProduct = Console.ReadLine().Split('-').ToArray();
                string productName = currentProduct[0];
                string productPrice = currentProduct[1];

                products[productName] = decimal.Parse(productPrice);
            }
        }
    }
}
