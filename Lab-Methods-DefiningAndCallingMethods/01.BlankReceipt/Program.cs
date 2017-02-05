using System;

namespace _01.BlankReceipt
{
    class Program
    {
        static void Main()
        {
            PrintRecipe();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-',30));
        }

        static void PrintMiddle()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintFooter()
        {
            Console.WriteLine(new string('-',30));
            Console.WriteLine("\u00A9 SoftUni");
        }

        static void PrintRecipe()
        {
            PrintHeader();
            PrintMiddle();
            PrintFooter();
        }
    }
}
