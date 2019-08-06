using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elmosify.Models.People;
using Elmosify.Services.Artists;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Elmosify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        ArtistsService artistsService = new ArtistsService();

        [HttpGet]
        public IActionResult Get()
        {
            var artists = artistsService.GetAllArtists();
            return Ok(artists);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var artist = artistsService.GetArtistById(id);
            if (artist == null) {
                return NotFound();
            }
            else
            {
                return Ok(artist);
            }
        }

        [HttpPost]
        public IActionResult Post(Artist a) {
            var newArtist = artistsService.AddArtist(a);
            return Ok(newArtist);
        }
    }
}