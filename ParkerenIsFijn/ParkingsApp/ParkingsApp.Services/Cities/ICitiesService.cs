using ParkingsApp.Models.Cities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingsApp.Services.Cities
{
    public interface ICitiesService
    {
        IEnumerable<City> GetAll();
        City GetCityById(Guid id);
        City CreateCity(City city);
        void DeleteCity(City city);
        void UpdateCity(City city);
    }
}

