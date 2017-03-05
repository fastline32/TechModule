using System;
using System.Collections.Generic;

namespace _02.Dict_Ref
{
    class DictRef
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            Dictionary<string,int> result = new Dictionary<string, int>();

            while (inputLine != "end")
            {
                var inputLineSplited = inputLine.Trim().Split();
                var name = inputLineSplited[0];
                var value = inputLineSplited[inputLineSplited.Length - 1];

                var tested = 0;
                var resultValue = int.TryParse(value, out tested);
                if (resultValue)
                {
                    result[name] = tested;
                    
                }
                else if (result.ContainsKey(value))
                {
                    var referencedValue = result[value];
                    result[name] = referencedValue;
                }
                inputLine = Console.ReadLine();
            }
            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key} === {pair.Value}");
            }
        }
    }
}
