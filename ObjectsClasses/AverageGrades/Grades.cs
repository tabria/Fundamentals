using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }  
        }
    }

    class Grades
    {
        static void Main()
        {

            Student[] AllStudents = GetStudentsData();

            var arr = AllStudents.Where(d => d.AverageGrade >= 5.00)
                                 .OrderBy(s => s.Name)
                                 .ThenByDescending(d => d.AverageGrade)
                                 .ToArray();

           Console.WriteLine(string.Join(Environment.NewLine, arr.Select(s=>s.Name + " -> " + $"{s.AverageGrade:f2}")));
        }

        static Student[] GetStudentsData()
        {
            int cycles = int.Parse(Console.ReadLine());
            Student[] studentsData = new Student[cycles]; 

            for (int i=0; i<cycles; i++)
            {
                string[] currentStudent = Console.ReadLine().Split(' ').ToArray();

                Student student = new Student();
                student.Name = currentStudent[0];
                student.Grades = currentStudent.Skip(1).Select(double.Parse).ToList();
                studentsData[i] = student;
            }

            return studentsData;
        }
    }
}
