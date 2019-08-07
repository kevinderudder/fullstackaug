using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingsApp.Api
{
    public static class AuthenticationHelper
    {
        public static void ConfigureAuthentication(
                this IServiceCollection services,
                IConfiguration config)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(
                       options => {
                           var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:ServerSecret"]));
                           options.TokenValidationParameters = new TokenValidationParameters
                           {
                               IssuerSigningKey = secretKey,
                               ValidIssuer = config["JWT:Issuer"],
                               ValidAudience = config["JWT:Issuer"]
                           };
                       } 
                    );
        }
    }
}
