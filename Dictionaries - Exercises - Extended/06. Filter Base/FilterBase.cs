using System;
using System.Collections.Generic;

namespace _06.Filter_Base
{
    class FilterBase
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            Dictionary<string,int> ageFiltered = new Dictionary<string, int>();
            Dictionary<string,double>salaryFiltered = new Dictionary<string, double>();
            Dictionary<string,string>positionFiltered = new Dictionary<string, string>();
            int age = 0;
            double salary = 0.0;
            while (inputLine != "filter base")
            {
                var token = inputLine.Trim().Split();
                var name = token[0];
                var quantity = token[token.Length - 1];
                var ageResult = int.TryParse(quantity, out age);
                var selaryResult = double.TryParse(quantity, out salary);
                if (ageResult)
                {
                    ageFiltered[name] = age;
                }
                else if (selaryResult)
                {
                    salaryFiltered[name] = salary;
                }
                else
                {
                    positionFiltered[name] = quantity;
                }
                inputLine = Console.ReadLine();
            }
            inputLine = Console.ReadLine();
            switch (inputLine)
            {
                case "Position":
                    foreach (var item in positionFiltered)
                    {
                        Console.WriteLine($"Name: {item.Key}");
                        Console.WriteLine($"Position: {item.Value}");
                        Console.WriteLine(new string('=',20));
                    } break;
                case "Age":
                    foreach (var item in ageFiltered)
                    {
                        Console.WriteLine($"Name: {item.Key}");
                        Console.WriteLine($"Age: {item.Value}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
                case "Salary":
                    foreach (var item in salaryFiltered)
                    {
                        Console.WriteLine($"Name: {item.Key}");
                        Console.WriteLine($"Salary: {item.Value:f2}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
            }
        }
    }
}
