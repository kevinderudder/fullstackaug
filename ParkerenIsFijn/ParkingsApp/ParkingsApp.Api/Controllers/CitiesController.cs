using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingsApp.Models.Cities;
using ParkingsApp.Services.Cities;

namespace ParkingsApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CitiesController : ControllerBase
    {
        private readonly ICitiesService citiesService;

        public CitiesController(ICitiesService citiesService)
        {
            this.citiesService = citiesService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var cities = this.citiesService.GetAll();
            return Ok(cities);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id) {
            var city = this.citiesService.GetCityById(id);
            if (city == null) return NotFound();
            else return Ok(city);
        }

        [HttpPost]
        public IActionResult Post(City city)
        {
            var newCity = this.citiesService.CreateCity(city);
            return CreatedAtAction("get", city.Id);
        }

        [HttpDelete]
        public IActionResult Delete(City city) {
            this.citiesService.DeleteCity(city);
            return NoContent();
        }
    }
}