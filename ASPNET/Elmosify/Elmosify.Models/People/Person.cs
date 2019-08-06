using System;
using System.Collections.Generic;
using System.Text;

namespace Elmosify.Models.People
{
    public abstract class Person
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public override string ToString()
        {
            return $"{this.Firstname} {this.Lastname}";
        }
    }
}
