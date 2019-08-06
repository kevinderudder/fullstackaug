using Elmosify.Models.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elmosify.Services.Artists
{
    public class ArtistsService:IArtistsService
    {
        public List<Artist> GetAllArtists() {
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

        public Artist GetArtistById(int id) {
            if (id == 13) return null;

            var artist = new Artist()
            {
                Firstname = "Tom",
                Lastname = "Waits",
                Band = "Tom Waits band"
            };

            return artist;
        }

        public Artist AddArtist(Artist a)
        {
            a.Id = Guid.NewGuid();
            return a;
        }
    }

    public class DutchArtistsService:IArtistsService
    {
        public List<Artist> GetAllArtists()
        {
            List<Artist> artists = new List<Artist>();

            artists.Add(new Artist()
            {
                Firstname = "Koen",
                Lastname = "Wauters",
                Band = "Clouseau"
            });

            artists.Add(new Artist()
            {
                Firstname = "Danna",
                Lastname = "Winner",
                Band = "Queens of the Stone Age"

            });

            return artists;
        }

        public Artist GetArtistById(int id)
        {
            if (id == 13) return null;

            var artist = new Artist()
            {
                Firstname = "Tom",
                Lastname = "Waits",
                Band = "Tom Waits band"
            };

            return artist;
        }

        public Artist AddArtist(Artist a)
        {
            a.Id = Guid.NewGuid();
            return a;
        }
    }
}
