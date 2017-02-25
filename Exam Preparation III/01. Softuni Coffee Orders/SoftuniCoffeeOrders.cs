using System;
using System.Globalization;

namespace _01.Softuni_Coffee_Orders
{
    class SoftuniCoffeeOrders
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                decimal priceOfCapsule =decimal.Parse( Console.ReadLine());
                DateTime orderDay = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsuleCount = long.Parse(Console.ReadLine());
                int days = DateTime.DaysInMonth(orderDay.Year, orderDay.Month);
                var total = (((decimal)days * capsuleCount) * priceOfCapsule);
                totalPrice += total;
                Console.WriteLine($"The price for the coffee is: ${ total:f2}");
               
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
