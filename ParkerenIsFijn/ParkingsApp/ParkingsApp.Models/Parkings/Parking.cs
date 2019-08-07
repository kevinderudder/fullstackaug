using ParkingsApp.Models.Cities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ParkingsApp.Models.Parkings
{
    public class Parking : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        public string Address { get; set; }

        [Required]
        public int AvailableCapacity { get; set; }

        [Required]
        public int TotalCapacity { get; set; }

        public City City { get; set; }

        public override string ToString()
        {
            return $"{this.Title}: {this.AvailableCapacity}/{this.TotalCapacity}";
        }
    }
}



