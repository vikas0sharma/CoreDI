using Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Stream
{
    public class SeriesStreamService : IStreamService
    {
        public IEnumerable<string> GetNames()
        {
            return new List<string> { "F.R.I.E.N.D.S", "Dexter", "Breaking Bad" };
        }
    }
}
