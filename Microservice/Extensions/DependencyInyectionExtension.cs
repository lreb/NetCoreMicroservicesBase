using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Extensions
{
    public static class DependencyInyectionExtension
    {
        /// <summary>
        /// Set all dependencies
        /// </summary>
        /// <param name="services"></param>
        public static void DependencyInyectionConfiguration(this IServiceCollection services)
        {
            //services.AddTransient<IContainersServices, ContainersServices>();

            //services.AddTransient<IHashManager, HashManager>();

            //services.AddScoped<Interfaces.StackTraceServices.IAuthenticationsServices, iFactoryDataLayer.StackTrace.AuthenticationsServices>();

            //services.AddScoped<Interfaces.StackTraceServices.IWipServices, iFactoryDataLayer.StackTrace.WipServices>();

            //services.AddScoped<Interfaces.Shipping.IShippingService, iFactoryDataLayer.Shipping.ShippingService>();

        }
    }
}
