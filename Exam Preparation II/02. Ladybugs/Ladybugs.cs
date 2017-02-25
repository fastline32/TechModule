namespace Ladybugs
{
    using System;
    using System.Linq;

    public class Start
    {
        public static int arraySize = 0;
        public static void Main()
        {
            arraySize = int.Parse(Console.ReadLine());
            int[] arr = new int[arraySize];

            int[] ladyBugIndexes = Console.ReadLine()
                                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

            foreach (var index in ladyBugIndexes)
            {
                if (IsInRange(index))
                {
                    arr[index] = 1;
                }
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line.ToLower() == "end")
                {
                    break;
                }

                string[] args = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string command = args[1].ToLower();
                int index = int.Parse(args[0]);
                int count = int.Parse(args[2]);

                // if index is int range
                if (IsInRange(index))
                {
                    // if ladybug exist on index
                    if (arr[index] == 1)
                    {
                        if (command == "right")
                        {
                            if (count > 0)
                            {
                                MoveRight(arr, index, Math.Abs(count));
                            }
                            else if (count < 0)
                            {
                                MoveLeft(arr, index, Math.Abs(count));
                            }
                        }
                        else if (command == "left")
                        {
                            if (count > 0)
                            {
                                MoveLeft(arr, index, Math.Abs(count));
                            }
                            else if (count < 0)
                            {
                                MoveRight(arr, index, Math.Abs(count));
                            }
                        }
                    }

                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }

        private static void MoveRight(int[] arr, int index, int count)
        {
            if (arr[index] == 1)
            {
                arr[index] = 0;
                index = index + count;

                while (IsInRange(index))
                {
                    if (arr[index] == 0)
                    {
                        arr[index] = 1;
                        break;
                    }
                    index = index + count;
                }
            }
        }

        private static void MoveLeft(int[] arr, int index, int count)
        {
            if (arr[index] == 1)
            {
                arr[index] = 0;
                index = index - count;

                while (IsInRange(index))
                {
                    if (arr[index] == 0)
                    {
                        arr[index] = 1;
                        break;
                    }
                    index = index - count;
                }
            }
        }

        public static bool IsInRange(int index)
        {
            bool isInRange = true;

            if (index < 0)
            {
                isInRange = false;
            }
            if (index >= arraySize)
            {
                isInRange = false;
            }

            return isInRange;
        }
    }
}