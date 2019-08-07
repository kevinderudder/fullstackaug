using Elmosify.Models.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elmosify.Repositories.Artists
{
    public interface IArtistsRepository
    {
        List<Artist> GetAll();
        Artist GetById(Guid id);
        void Update(Artist a);
        void Delete(Artist a);
        Artist Create(Artist a);
    }
}
