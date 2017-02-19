using System.IO;
using System.Linq;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main()
        {
            var line1 = File.ReadAllLines("input1.txt").ToArray();
            var line2 = File.ReadAllLines("input2.txt").ToArray();

            var result = new string[line1.Length+line2.Length];
            for (int i = 0; i < line1.Length; i++)
            {
                result[i * 2] = line1[i];
            }
            for (int i = 0; i < line2.Length; i++)
            {
                result[i * 2 + 1] = line2[i];
            }
            File.WriteAllLines("result.txt",result);
        }
    }
}
