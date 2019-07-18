using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyResolver
{
    public class DependencyRegister : IDependencyRegister
    {
        private readonly IServiceCollection serviceCollection;

        public DependencyRegister(IServiceCollection serviceCollection)
        {
            this.serviceCollection = serviceCollection;
        }
        public void AddTransient<TFrom, TTo>() where TTo : class, TFrom where TFrom : class
        {
            serviceCollection.AddTransient<TFrom, TTo>();
        }

        public void AddScoped<TFrom, TTo>() where TTo : class, TFrom where TFrom : class
        {
            serviceCollection.AddScoped<TFrom, TTo>();
        }

        public void AddScopedForMultiImplementation<TFrom, TTo>() where TTo : class, TFrom where TFrom : class
        {
            serviceCollection.AddScoped<TTo>()
                .AddScoped<TFrom, TTo>(s => s.GetService<TTo>());
        }
    }
}
