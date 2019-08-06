using Elmosify.Models.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elmosify.Services.Artists
{
    public interface IArtistsService
    {
        List<Artist> GetAllArtists();
        Artist GetArtistById(int id);
        Artist AddArtist(Artist a);
    }
}
