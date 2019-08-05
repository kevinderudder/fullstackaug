using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFeatures.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "kevin";
            Console.WriteLine(name.ToXml("name")); // <name>kevin</name>
            
            
            
            //Person p = new Person("Recruiter", "Alfonso", 32);
            var people = Person.GeneratePeople();


            var youngPeople = from p in people
                              where p.Age < 40
                              orderby p.Firstname ascending, p.Lastname descending
                              select p;


            var oldPeople = people.Where(p => p.Age > 40).OrderBy(p => p.Firstname);

            PrintPeople(youngPeople);

        }


        static void PrintPeople(IEnumerable<Person> people) {

            //for (int i = 0; i < people.Count(); i++) {
            //    Console.WriteLine($" > {people[i]}");
            //}

            foreach (Person p in people)
            {
                Console.WriteLine($" > {p}");
            }
        }

        static void PrintYoungPeople(List<Person> people)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Age < 40) {
                    Console.WriteLine($" > {people[i]}");
                }
            }
        }


        static void BoxingUnboxing() {
            int i = 42;
            object nr = i;

            List<string> nrs = new List<string>();
            
        }


    }
}
