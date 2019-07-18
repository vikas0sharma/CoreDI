using Contracts.Services;
using DependencyResolver;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;

namespace Services.Stream
{
    [Export(typeof(IDependencyResolver))]
    public class StreamServiceResolver : IDependencyResolver
    {
        public void SetUp(IDependencyRegister dependencyRegister)
        {
            dependencyRegister.AddScopedForMultiImplementation<IStreamService, MoviesStreamService>();
            dependencyRegister.AddScopedForMultiImplementation<IStreamService, SeriesStreamService>();
            dependencyRegister.AddScoped<IStreamFactory, StreamFactory>();
            dependencyRegister.AddScoped<IValesService, ValesService>();
        }
    }
}
