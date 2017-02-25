using System;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            var digit1 = Console.ReadLine();
            var digit2 = int.Parse(Console.ReadLine());
            var res = 0;
            var toAdd = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = digit1.Length - 1; i >= 0; i--)
            {
                res = digit2 * int.Parse(digit1[i].ToString()) + toAdd;
                if (res > 9)
                {
                    if (i == 0)
                    {
                        sb.Append(res % 10);
                        sb.Append(res / 10);
                    }
                    else
                    {
                        toAdd = res / 10;
                        res = res % 10;
                        sb.Append(res);
                    }
                }
                else
                {
                    toAdd = 0;
                    sb.Append(res);
                }
            }
            var result = new string(sb.ToString().ToCharArray().Reverse().ToArray()).TrimStart('0');
            bool flagZero = true;
            foreach (var item in result)
            {
                if (item != '0')
                {
                    flagZero = false;
                }
            }
            if (flagZero)
            {
                result = "0";
            }
            Console.WriteLine(result);
        }
    }
}