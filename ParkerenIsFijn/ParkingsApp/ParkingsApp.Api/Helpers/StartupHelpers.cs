using Microsoft.Extensions.DependencyInjection;
using ParkingsApp.Models.Cities;
using ParkingsApp.Repositories;
using ParkingsApp.Repositories.Cities;
using ParkingsApp.Services.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingsApp.Api
{
    public static class StartupHelpers
    {

        public static void RegisterServices(this IServiceCollection services) {
            services.AddSingleton<IRepository<City>, CitiesRepository>();
            services.AddTransient<ICitiesService, CitiesService>();
        }

    }
}
