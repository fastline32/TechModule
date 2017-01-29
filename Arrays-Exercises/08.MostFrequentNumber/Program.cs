using System;
using System.Collections.Generic;
using System.Linq;


namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main()
        {

            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var number = 0;
            var occurence = new int[65535];
            var minJ = 0;
            //var arrNum = new List<int>();
            var occurencies = 0;

            for (int i = 0; i < input.Length; i++)
            {
                occurence[input[i]]++;
            }

            var max = occurence.Max();
            for (int i = 0; i < occurence.Length; i++)
            {
                if (max == occurence[i])
                {
                    number = i;
                    occurencies++;
                }
            }

            if (occurencies > 1)
            {
                for (int j = 0; j < input.Length; j++)
                {

                    if (input[j] == number)
                    {
                        if (j < minJ)
                        {
                            minJ = j;
                        }
                    }
                }
                Console.WriteLine(input[minJ]);
            }
            else Console.WriteLine(number);
        }
    }
}