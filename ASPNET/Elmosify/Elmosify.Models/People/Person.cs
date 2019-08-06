using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Elmosify.Models.People
{
    public abstract class Person:BaseEntity
    {
        [Required]
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public bool IsDeleted { get; set; } // true --> 1 (soft delete)

        public override string ToString()
        {
            return $"{this.Firstname} {this.Lastname}";
        }
    }
}
