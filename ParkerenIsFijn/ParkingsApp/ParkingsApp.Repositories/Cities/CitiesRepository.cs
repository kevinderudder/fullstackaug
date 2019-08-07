using ParkingsApp.Models.Cities;
using ParkingsApp.Models.Parkings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ParkingsApp.Repositories.Cities
{
    public class CitiesRepository : IRepository<City>
    {
        private List<City> cities;
        public CitiesRepository()
        {
            cities = new List<City>();
            cities.Add(new City() {
                Id = Guid.NewGuid(),
                Title = "Gent",
                Zip = "9000",
                Parkings = new List<Parking>() {
                    new Parking(){
                        Id = Guid.NewGuid(),
                        Title = "Vrijdagmarkt",
                        AvailableCapacity = 200,
                        TotalCapacity = 400
                    }
                }
            });

            cities.Add(new City()
            {
                Id = Guid.NewGuid(),
                Title = "Lichtervelde",
                Zip = "8810"
            });

            cities.Add(new City() {
                Id = Guid.NewGuid(),
                Title = "Nijlen",
                Zip = "2560"
            });
        }

        public City Create(City entity)
        {
            this.cities.Add(entity);
            return entity;
        }

        public void Delete(City entity)
        {
            this.cities.Remove(entity);
        }

        public IEnumerable<City> GetAll()
        {
            return this.cities;
        }

        public City GetById(Guid id)
        {
            var city = from c in this.cities
                       where c.Id == id
                       select c;
            return city.SingleOrDefault();

            // return this.cities.Where(c => c.Id == id).SingleOrDefault();

        }

        public void Update(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
