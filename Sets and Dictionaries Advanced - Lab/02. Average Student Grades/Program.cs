using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string student = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<decimal>());
                }

                students[student].Add(grade);
            }

            foreach (var student in students)
            {
                decimal average = student.Value.Average();

                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.Write($"(avg: {average:f2})");

                Console.WriteLine();
            }
        }
    }
}
