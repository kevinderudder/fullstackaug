using Elmosify.Models.People;
using Elmosify.Repositories;
using Elmosify.Repositories.Artists;
using Elmosify.Services.Artists;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elmosify.Api
{
    public static class StartupHelpers
    {

        public static void RegisterServices(this IServiceCollection services) {
            services.AddTransient<IArtistsService, ArtistsService>();
        }

        public static void RegisterRepositories(this IServiceCollection services) {
            services.AddTransient<IRepository<Artist>, ArtistsRepository>();
        }
    }
}
