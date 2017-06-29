using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace OrderByAge
{
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public long Age { get; set; }
    }

    class OrderAge
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();
            while (true)
            {
                string[] personInfo = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (personInfo[0] == "End")
                {
                    break;
                }

                Person person = new Person
                {
                    Name = personInfo[0],
                    Id = personInfo[1],
                    Age = int.Parse(personInfo[2])
                };

                persons.Add(person);
            }

            foreach( var person in persons.OrderBy(i => i.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }

        }
    }
}
