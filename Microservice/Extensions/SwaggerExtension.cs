using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Swagger;
using System.Reflection;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Microservice.Extensions
{
    public static class SwaggerExtension
    {
        /// <summary>
        /// Swagger Configuration
        /// </summary>
        /// <param name="services"></param>
        public static void ApiDocumentation(this IServiceCollection services, IConfiguration config)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = config["SwaggerConfiguration:Title"],
                    Version = config["SwaggerConfiguration:Version"],
                    Description = config["SwaggerConfiguration:Description"],
                    TermsOfService = config["SwaggerConfiguration:TermsOfService"],
                    Contact = new Contact
                    {
                        Name = config["SwaggerConfiguration:ContactName"],
                        Email = config["SwaggerConfiguration:ContactEmail"],
                    },
                    License = new License
                    {
                        Name = config["SwaggerConfiguration:LicenseName"],
                        Url = config["SwaggerConfiguration:LicenseUrl"],
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }
    }
}
