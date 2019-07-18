using Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Stream
{
    public class ValesService : IValesService
    {
        private readonly IStreamService moviesService;
        private readonly IStreamService seriesService;
        public ValesService(IStreamFactory streamFactory)
        {
            moviesService = streamFactory.GetService<MoviesStreamService>();
            seriesService = streamFactory.GetService<SeriesStreamService>();
        }
        public IEnumerable<string> GetMovies()
        {
            return moviesService.GetNames();
        }

        public IEnumerable<string> GetSeries()
        {
            return seriesService.GetNames();
        }
    }
}
