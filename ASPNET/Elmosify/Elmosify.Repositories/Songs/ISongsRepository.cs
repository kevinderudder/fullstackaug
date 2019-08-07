using Elmosify.Models.Songs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elmosify.Repositories.Songs
{
    public interface ISongsRepository
    {
        List<Song> GetAll();
        Song GetById(Guid id);
        void Update(Song a);
        void Delete(Song a);
        Song Create(Song a);
    }
}
