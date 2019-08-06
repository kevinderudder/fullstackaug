using Elmosify.Models.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elmosify.Models.Songs
{
    public class Song:BaseEntity
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public Artist Artist { get; set; }
        public bool IsDeleted { get; set; }

        public override string ToString()
        {
            return $"{this.Title} by {this.Artist.ToString()}";
        }
    }
}
