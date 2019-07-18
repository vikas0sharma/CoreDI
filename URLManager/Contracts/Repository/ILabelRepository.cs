using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Repository
{
    public interface ILabelRepository
    {
        IEnumerable<string> GetLables();
    }
}
