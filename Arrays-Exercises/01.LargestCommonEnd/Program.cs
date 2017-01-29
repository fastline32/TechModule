using System;
using System.Linq;

class LargestCommonEnd
{
    static void Main(string[] args)
    {
        string[] firstString = Console.ReadLine().Split(' ').ToArray();
        string[] secondString = Console.ReadLine().Split(' ').ToArray();
        largestCommonEnd(firstString, secondString);
    }

    static void largestCommonEnd(string[] first, string[] second)
    {
        int rightCount = 0;
        int leftCount = 0;
        while (rightCount < first.Length && rightCount < second.Length)
        {
            if (first[first.Length - rightCount - 1] == second[second.Length - rightCount - 1])
            {
                rightCount++;
            }
            else break;
        }

        while (leftCount < first.Length && leftCount < second.Length)
        {
            if (first[leftCount] == second[leftCount])
            {
                leftCount++;
            }
            else break;
        }

        if (rightCount > leftCount)
        {
            Console.WriteLine(rightCount);
        }
        else
        {
            Console.WriteLine(leftCount);
        }
    }
}