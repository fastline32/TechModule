using System;
using System.Collections.Generic;
using System.Linq;

namespace Sales_Report
{
    class Program
    {
        static void Main()
        {
            var rows = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, 4];

            for (int row = 0; row < rows; row++)
            {
                string[] cells = Console.ReadLine().Split(' ').ToArray();

                for (int col = 0; col < 4; col++)
                {
                    matrix[row, col] = cells[col];
                }
            }

            List<string> towns = new List<string>();

            towns.Add(matrix[0, 0]);

            for (int i = 1; i < rows; i++)
            {
                if (!towns.Contains(matrix[i, 0]))
                {
                    towns.Add(matrix[i, 0]);
                }
            }

            for (int i = 0; i < towns.Count; i++)
            {
                towns.Sort();
                Console.Write(towns[i]);
                double tempResult = 0;
                double result = 0;
                for (int j = 0; j < rows; j++)
                {
                    if (matrix[j, 0] == towns[i])
                    {
                        tempResult = double.Parse(matrix[j, 2]) * double.Parse(matrix[j, 3]);
                        result += tempResult;
                    }

                }
                Console.WriteLine(" -> {0:f2}", result);
            }

        }
    }
}