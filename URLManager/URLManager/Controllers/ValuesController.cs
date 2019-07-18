using System.Collections.Generic;
using Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace URLManager.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ILabelService labelService;
        private readonly IValesService valesService;

        public ValuesController(ILabelService labelService, IValesService valesService)
        {
            this.labelService = labelService;
            this.valesService = valesService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return labelService.GetLables();
        }

        [HttpGet("movies")]
        public IEnumerable<string> GetMovies()
        {
            return valesService.GetMovies();
        }

        [HttpGet("series")]
        public IEnumerable<string> GetSeries()
        {
            return valesService.GetSeries();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
