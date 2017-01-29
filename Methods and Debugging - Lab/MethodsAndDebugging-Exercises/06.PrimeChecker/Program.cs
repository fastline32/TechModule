using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }

        static bool IsPrime(long n)
        {
            if (n == 0) return false;
            if (n == 1) return false;
            if (n == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 2; i <= boundary; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
