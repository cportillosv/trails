using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using trails.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace trails.Controllers
{
    [Route("api/[controller]")]
    public class RunnerController : Controller
    {
        // GET: api/values
        [HttpGet]
        public List<Runner> Get()
        {
            var runners = new List<Runner>{
                new Runner{Id=1,First="Enrique",Last="Cuadra",Age=65,FavoriteBeer="Pilsener"},
                new Runner{Id=2,First="Carlos",Last="Portillo",Age=29,FavoriteBeer="Corona"}
            };
            
            return runners;
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
