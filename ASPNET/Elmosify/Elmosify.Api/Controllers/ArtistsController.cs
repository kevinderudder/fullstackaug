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
        private readonly IArtistsService artistsService;

        //ArtistsService artistsService = new ArtistsService();

        public ArtistsController(IArtistsService artistsService)
        {
            this.artistsService = artistsService;
        }

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
            //if (!ModelState.IsValid) return BadRequest();
            var newArtist = artistsService.AddArtist(a);
            //return Created("http://" + newArtist.Id, newArtist);
            return CreatedAtAction("get", newArtist);
        }

        [HttpDelete]
        public IActionResult Delete(Artist a) {
            // db actions
            return NoContent();
        }
    }
}