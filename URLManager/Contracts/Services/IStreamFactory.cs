using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Services
{
    public interface IStreamFactory
    {
        IStreamService GetService<TImplementation>() where TImplementation : IStreamService;
    }
}
