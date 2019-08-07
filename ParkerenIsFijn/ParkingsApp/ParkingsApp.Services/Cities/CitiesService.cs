using System;
using System.Collections.Generic;
using System.Text;
using ParkingsApp.Models.Cities;
using ParkingsApp.Repositories;

namespace ParkingsApp.Services.Cities
{
    public class CitiesService : ICitiesService
    {
        private readonly IRepository<City> citiesRepo;

        public CitiesService(IRepository<City> citiesRepo)
        {
            this.citiesRepo = citiesRepo;
        }

        public City CreateCity(City city)
        {
            return this.citiesRepo.Create(city);
        }

        public void DeleteCity(City city)
        {
            this.citiesRepo.Delete(city);
        }

        public IEnumerable<City> GetAll()
        {
            return this.citiesRepo.GetAll();
        }

        public City GetCityById(Guid id)
        {
            return this.citiesRepo.GetById(id);
        }

        public void UpdateCity(City city)
        {
            throw new NotImplementedException();
        }
    }
}
