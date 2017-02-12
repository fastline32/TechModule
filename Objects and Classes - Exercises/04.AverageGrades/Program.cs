using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double Average { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<Student> ListOfStudents = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                Student next = new Student();
                next.Name = line[0];
                next.Grades = new double[line.Length - 1];
                for (int j = 0; j < line.Length-1; j++)
                {
                    next.Grades[j] = double.Parse(line[j + 1]);
                }
                next.Average = next.Grades.Average();
                ListOfStudents.Add(next);
            }
            List<Student> forPrint = new List<Student>();
            foreach (var item in ListOfStudents)
            {
                if (item.Average >= 5)
                {
                    forPrint.Add(item);
                }
            }
            forPrint = forPrint.Where(x => x.Average >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.Average).ToList();
            foreach (var item in forPrint)
            {
                Console.WriteLine($"{item.Name} -> {item.Average:f2}");
            }
        }
    }
}
