using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne = "Hello";
            string stringTwo = "World";
            object itemOne = stringOne + " " + stringTwo;
            string stringThree = Convert.ToString(itemOne);
            Console.WriteLine(stringThree);
        }
    }
}
