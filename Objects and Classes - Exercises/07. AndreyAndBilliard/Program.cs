using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AndreyAndBilliard
{
    class Pr07AndreyAndBilliard
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> infoItems = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine().Split('-').ToArray();
                string product = info[0];
                decimal price = decimal.Parse(info[1]);
                infoItems[product] = price;
            }

            string line = string.Empty;
            List<Customer> customers = new List<Customer>();

            while ((line = Console.ReadLine()) != "end of clients")
            {
                string[] infocustomer = line.Split('-');
                string[] orderInfo = infocustomer[1].Split(',');

                if (infoItems.ContainsKey(orderInfo[0]))
                {
                    Customer customer = new Customer();
                    customer.Name = infocustomer[0];

                    int piecesProduct = int.Parse(orderInfo[1]);
                    string product = orderInfo[0];

                    if (customers.Any(c1 => c1.Name == infocustomer[0]))
                    {
                        customer = customers.First(cl => cl.Name == infocustomer[0]);

                        if (!customer.Order.ContainsKey(product))
                        {
                            customer.Order.Add(product, piecesProduct);
                            customer.Bill += piecesProduct * infoItems[product];
                        }
                        else
                        {
                            customer.Order[product] += piecesProduct;
                            customer.Bill += piecesProduct * infoItems[product];
                        }
                    }
                    else
                    {
                        customer.Order = new Dictionary<string, int>();

                        customer.Order.Add(product, piecesProduct);
                        customer.Bill = piecesProduct * infoItems[product];
                        customers.Add(customer);
                    }
                }
            }

            decimal sum = 0;
            foreach (var client in customers.OrderBy(cl => cl.Name))
            {
                Console.WriteLine(client.Name);

                foreach (var item in client.Order)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                Console.WriteLine($"Bill: {client.Bill:f2}");

                sum += client.Bill;
            }

            Console.WriteLine($"Total bill: {sum:f2}");
        }
    }

    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> Order { get; set; }

        public decimal Bill { get; set; }
    }
}