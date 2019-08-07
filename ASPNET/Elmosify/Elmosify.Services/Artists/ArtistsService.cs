using Elmosify.Models.People;
using Elmosify.Repositories;
using Elmosify.Repositories.Artists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elmosify.Services.Artists
{
    public class ArtistsService:IArtistsService
    {
        private readonly IRepository<Artist> artistsRepo;

        public ArtistsService(IRepository<Artist> artistsRepo)
        {
            this.artistsRepo = artistsRepo;
        }

        public List<Artist> GetAllArtists() {
            return artistsRepo.GetAll();
        }

        public Artist GetArtistById(int id) {
            return artistsRepo.GetById(Guid.NewGuid());
        }

        public Artist AddArtist(Artist a)
        {
            return artistsRepo.Create(a);
        }
    }
}
