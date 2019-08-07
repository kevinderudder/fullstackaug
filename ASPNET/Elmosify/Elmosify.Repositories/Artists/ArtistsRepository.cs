using System;
using System.Collections.Generic;
using System.Text;
using Elmosify.Models.People;

namespace Elmosify.Repositories.Artists
{
    public class ArtistsRepository : IRepository<Artist>
    {
        public Artist Create(Artist a)
        {
            a.Id = Guid.NewGuid();
            return a;
        }

        public void Delete(Artist a)
        {
            //throw new NotImplementedException();
        }

        public List<Artist> GetAll()
        {
            List<Artist> artists = new List<Artist>();

            artists.Add(new Artist()
            {
                Firstname = "Dan",
                Lastname = "Auerbach",
                Band = "Black Keys"
            });

            artists.Add(new Artist()
            {
                Firstname = "Josh",
                Lastname = "Stone",
                Band = "Queens of the Stone Age"

            });

            return artists;
        }

        public Artist GetById(Guid id)
        {
            //if (id == 13) return null;

            var artist = new Artist()
            {
                Firstname = "Tom",
                Lastname = "Waits",
                Band = "Tom Waits band"
            };

            return artist;
        }

        public void Update(Artist a)
        {
            //throw new NotImplementedException();
        }
    }
}
