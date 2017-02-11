using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class AMinerTask
    {
        static void Main()
        {
            Dictionary<string, long> resourceChart = new Dictionary<string, long>();
            long inputValue;
            string inputMetal = Console.ReadLine()
                .Trim();


            while (inputMetal != "stop")
            {
                inputValue = long.Parse(Console.ReadLine()
                    .Trim());

                if (resourceChart.ContainsKey(inputMetal))
                {
                    resourceChart[inputMetal] += inputValue;
                }
                else
                {
                    resourceChart.Add(inputMetal, inputValue);
                }
                inputMetal = Console.ReadLine();
            }

            foreach (var item in resourceChart)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}