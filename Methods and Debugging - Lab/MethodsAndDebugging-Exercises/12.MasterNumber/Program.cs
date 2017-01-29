using System;

namespace _12.MasterNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && SumOfDigit(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int num)
        {
            string sNum = num.ToString();
            for (int i = 0; i < sNum.Length / 2; i++)
            {
                if (sNum[i] != sNum[sNum.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static bool SumOfDigit(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum = sum + num % 10;
                num /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool ContainsEvenDigit(int num)
        {
            string sNum = num.ToString();
            int count = 0;
            for (int i = 0; i < sNum.Length; i++)
            {
                int current = int.Parse(sNum[i].ToString());
                if (current % 2 == 0)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
