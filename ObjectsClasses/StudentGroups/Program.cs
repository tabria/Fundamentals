using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace StudentGroups
{
    class Group
    {
        public string TownName { get; set; }
        public List<Student> Students { get; set; }
    }
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public List<Student> Students { get; set; } 
    }

    class Program
    {
        static void Main()
        {
            List<Town> city = new List<Town>();
            GetTownsStudents(city);
            List<Group> groups = new List<Group>();
            GetGoups(city, groups);
            PrintGroups(city, groups);


        }

        static void PrintGroups(List<Town> city, List<Group> groups)
        {
            Console.WriteLine($"Created {groups.Count} groups in {city.Count} towns:");
            foreach(var gep in groups.OrderBy(s => s.TownName))
            {
                Console.Write($"{gep.TownName}=> ");
                Console.Write(string.Join(", ", gep.Students.Select(s => s.Email)));
                Console.WriteLine();
            }
        }

        static void GetGoups(List<Town> city, List<Group> groups)
        {
            foreach (var town in city.OrderBy(s => s.Name))
            {
                var studs = town.Students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email);
                int count = 0;
                while (count < studs.Count())
                {
                    var group = new Group();
                    group.TownName = town.Name;
                    group.Students = studs.Skip(count).Take(town.Seats).ToList();
                    count += town.Seats;
                    groups.Add(group);
                }
            }
        }

        static void GetTownsStudents(List<Town> city)
        {
            while (true)
            {
                string dataEntry = Console.ReadLine();
                if (dataEntry == "End")
                {
                    break;
                }
      
                if (dataEntry.Contains("seats"))
                {
                    
                    AddTown(city, dataEntry);
                }
                else
                {
                    AddStudent(city, dataEntry);
                }
            }
        }

        static void AddStudent(List<Town> city, string dataEntry)
        {
            string[] currentStudent = dataEntry.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Student newStudent = new Student();
            newStudent.Name = currentStudent[0].Trim();
            newStudent.Email = currentStudent[1].Trim();
            newStudent.RegistrationDate = DateTime.ParseExact(currentStudent[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

            city[city.Count - 1].Students.Add(newStudent);
        }

        static void AddTown(List<Town> city, string dataEntry)
        {
            string[] currentTown = dataEntry.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] seatsCount = currentTown[1].Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Town curTown = new Town();
            curTown.Name = currentTown[0];
            curTown.Seats = int.Parse(seatsCount[0]);
            curTown.Students = new List<Student>();
            city.Add(curTown);
        }
    }
}
