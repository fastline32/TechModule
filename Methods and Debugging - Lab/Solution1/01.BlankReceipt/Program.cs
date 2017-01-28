using System;

namespace _01.BlankReceipt
{
    class Program
    {
        static void Main()
        {
            PrintRepiceHeader();
            PrintBody();
            PrintFooter();
        }

        static void PrintRepiceHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintFooter()
        {
            Console.WriteLine(new string('-',30));
            Console.WriteLine("\u00A9 SoftUni");
        }
    }
}
