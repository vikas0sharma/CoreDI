using Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Stream
{
    public class StreamFactory : IStreamFactory
    {
        private readonly IServiceProvider serviceProvider;

        public StreamFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        public IStreamService GetService<TImplementation>() where TImplementation : IStreamService
        {
           return (IStreamService)serviceProvider.GetService(typeof(TImplementation));
        }
    }
}
