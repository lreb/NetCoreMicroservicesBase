using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Extensions
{
    public static class SQLExtension
    {
        /// <summary>
        /// Connections string
        /// </summary>
        /// <param name="services"></param>
        /// <param name="config"></param>
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["DataBaseContextSQL:connectionString"];
            // services.AddDbContext<iFactoryCustomContext>(o => o.UseSqlServer(connectionString));
        }
    }
}
