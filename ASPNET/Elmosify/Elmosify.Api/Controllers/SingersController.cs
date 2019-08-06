using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elmosify.Services.Artists;
using Microsoft.AspNetCore.Mvc;

namespace Elmosify.Api.Controllers
{
    public class SingersController : Controller
    {
        private readonly IArtistsService artistsService;

        //ArtistsService artistsService = new ArtistsService();

        public SingersController(IArtistsService artistsService)
        {
            this.artistsService = artistsService;
        }

        public IActionResult Index()
        {
            var artists = artistsService.GetAllArtists();
            return View(artists);
        }

        public IActionResult Edit(int id)
        {
            var artist = artistsService.GetArtistById(id);
            return View(artist);
        }
    }
}