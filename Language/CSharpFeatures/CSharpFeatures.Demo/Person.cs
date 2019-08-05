using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.Demo
{
    public class Person: IDrive, ILicenseTiKill
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(string firstname, string lastname)
            : this(firstname, lastname, 0)
        {
            //this.Firstname = firstname;
            //this.Lastname = lastname;
            //this.Age = 0;

        }

        public Person(string firstname, string lastname, int age) {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
        }

        public static List<Person> GeneratePeople() {
            Person p1 = new Person("Kevin", "DeRudder", 42);
            Person p2 = new Person("Nathalie", "Emmanuel", 28);
            Person p3 = new Person("Dan", "Auerbach", 55);

            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            people.Add(p3);

            return people;
        }

        public override string ToString()
        {
            return $"{this.Firstname} {this.Lastname}";
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Kill()
        {
            throw new NotImplementedException();
        }
    }

    public interface IDrive {
        void Drive();
    }

    public interface ILicenseTiKill {
        void Kill();
    }

   
}
