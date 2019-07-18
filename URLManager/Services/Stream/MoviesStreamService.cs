using Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Stream
{
    public class MoviesStreamService : IStreamService
    {
        public IEnumerable<string> GetNames()
        {
            return new List<string> { "Dark Knight", "Dark Knight Rises", "Mr. Nobody" };
        }
    }
}
