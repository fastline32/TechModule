using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class BombNumbers
    {
        static void Main()
        {
            List<decimal> numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            List<decimal> input = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (input[0] == numbers[i])
                {
                    for (int n = 0; n < input[1]; n++)
                    {
                        if (i < numbers.Count - 1)
                        {
                            numbers.RemoveAt(i + 1);
                        }
                        if (i >= 1)
                        {
                            numbers.RemoveAt(i - 1);
                        }
                        if (i == 0)
                        {
                            continue;
                        }
                        else
                        {
                            i--;
                        }

                    }
                    numbers.RemoveAt(i);
                    if (numbers.Contains(input[0]))
                    {
                        i = 0;
                    }
                }

            }
            Console.WriteLine(numbers.Sum());
        }
    }
}