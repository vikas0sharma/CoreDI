using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Services
{
    public interface IValesService
    {
        IEnumerable<string> GetMovies();
        IEnumerable<string> GetSeries();
    }
}
