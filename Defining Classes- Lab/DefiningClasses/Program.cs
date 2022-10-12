using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int members = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < members; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person();
                person.Name = name;
                person.Age = age;

                family.AddMember(person);
            }

            List<Person> orderedFamily = new List<Person>();

            orderedFamily = family.FamilyMembers.OrderBy(x => x.Name).Where(x => x.Age > 30).ToList();

            foreach (var person in orderedFamily)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
