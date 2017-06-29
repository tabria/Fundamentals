using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace MentorGroup
{

    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> AttendanceDates { get; set; }
    }

    class Menta
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            AddAllStudents(students);
            AddComments(students);
            PrintReport(students);

        }

        static void PrintReport(List<Student> students)
        {
           foreach (var stude in students.OrderBy(s=>s.Name))
            {
                Console.WriteLine(stude.Name);
                Console.WriteLine("Comments:");
                Console.Write(string.Join("", stude.Comments.Select(s=>$"- {s}" + Environment.NewLine)));
                Console.WriteLine("Dates attended:");
                Console.Write(string.Join("", stude.AttendanceDates.Select(dt => $"-- {dt.Date.ToString("dd/MM/yyyy")}" + Environment.NewLine).OrderBy(dt=>dt)));
            }
        }

        static void AddComments(List<Student> students)
        {

            while (true)
            {
                string[] currentComment = Console.ReadLine().Split('-').ToArray();

                if (currentComment[0] == "end of comments")
                {
                    break;
                }

                if (!students.Any(s=>s.Name.Contains(currentComment[0])))
                {
                    continue;
                }

                foreach (var stu in students.Where(s => s.Name == currentComment[0]))
                {
                    stu.Comments.Add(currentComment[1]);
                }
            }

        }

        static void AddAllStudents(List<Student> students)
        {
            while (true)
            {
                string[] currentStudent = Console.ReadLine().Split(' ').ToArray();
                string studentName = currentStudent[0];
                if (studentName == "end" && currentStudent.Length == 3)
                {
                    break;
                }

                List<DateTime> dates = new List<DateTime>();
                if (currentStudent.Length > 1)
                {
                    dates = currentStudent[1].Split(',').Select(s => DateTime.ParseExact(s, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                }
                

                bool isStudentExist = false;
                foreach (var st in students.Where(s=>s.Name == studentName))
                {
                    st.AttendanceDates.AddRange(dates);
                    isStudentExist = true;
                    break;
                }
                if (!isStudentExist)
                {
                    Student studente = new Student();
                    studente.Name = studentName;
                    studente.AttendanceDates = dates;
                    studente.Comments = new List<string>();
                    students.Add(studente);
                }
            }
        }
    }
}
