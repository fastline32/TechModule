using System;

namespace _01.Sweet_Dessert
{
    class SweetDessert
    {
        static void Main()
        {
            decimal cach = decimal.Parse(Console.ReadLine());
            decimal guests = decimal.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            decimal setsOfPortions = Math.Ceiling(guests / 6m);

            var totalPrice = (setsOfPortions * (2 * bananasPrice) + setsOfPortions * (4 * eggPrice) +
                              setsOfPortions * (0.2m * berriesPrice));

            if (totalPrice<=cach)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                var neededMoney = totalPrice - cach;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:f2}lv more.");
            }
        }
    }
}
