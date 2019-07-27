using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace StudentListAPI.Config.Extentions
{
    public static class SwaggerExtention
    {
        public static IServiceCollection AddOurSwaager(this IServiceCollection services)
        {
            // Swagger service properties
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Auth JWT",
                    Description = "Auth JWT Demo - angular-netcore.ir",
                    TermsOfService = "None",
                    Contact = new Contact()
                    {
                        Name = "Mohammad Moein Fazeli",
                        Email = "mmfazeli372@gmail.com",
                        Url = "http://www.angular-netcore.ir"
                    }
                });
            });
            return services;
        }
    }
}
