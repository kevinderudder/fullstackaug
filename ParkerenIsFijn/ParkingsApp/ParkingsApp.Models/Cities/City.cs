using ParkingsApp.Models.Parkings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ParkingsApp.Models.Cities
{
    public class City:BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Zip { get; set; }

        public IList<Parking> Parkings { get; set; }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
