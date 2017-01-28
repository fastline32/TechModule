using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string hexValuee = number.ToString("X");
            string binaryValue = Convert.ToString(number, 2);
            Console.WriteLine(hexValuee);
            Console.WriteLine(binaryValue);
        }
    }
}
