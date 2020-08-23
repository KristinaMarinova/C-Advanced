using System;
using System.Collections.Generic;
using System.Linq;
class AverageStudentGrades
    {
        public static void Main()
        {
            int numberOfRecords = int.Parse(Console.ReadLine());

            var studentsRecords = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfRecords; i++)
            {
                string[] inputTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string studentName = inputTokens[0];
                double studentGrade = double.Parse(inputTokens[1]);

                if (studentsRecords.ContainsKey(studentName))
                {
                    studentsRecords[studentName].Add(studentGrade);
                }
                else
                {
                    studentsRecords.Add(studentName, new List<double>() { studentGrade });
                }
            }

            foreach (var record in studentsRecords)
            {
                string studentName = record.Key;
                string studentGrades = string.Join(' ', record.Value.Select(r => r.ToString($"{0:f2}")));
                double average = record.Value.Average();

                Console.WriteLine($"{studentName} -> {studentGrades} (avg: {average:F2})");
            }
        }
    }