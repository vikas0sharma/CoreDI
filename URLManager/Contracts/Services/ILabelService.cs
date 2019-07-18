using System.Collections.Generic;

namespace Contracts.Services
{
    public interface ILabelService
    {
        IEnumerable<string> GetLables();
    }
}
