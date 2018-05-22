using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using restapi.Models;
using restapi.Migrations;

namespace restapi.Controllers
{   
    [Produces("application/json")]
    [Route("api/Malls")]
    public class MallsController : Controller
    {

        // GET: api/Malls
        [HttpGet]
        public IEnumerable<Malls> Get()
        {
            //return new string[] { "value1", "value2" };         
            var shoplist = new List<Malls>
              {
                  new Malls{Id=1,Title="AL RASHID MEGA MALL-MADINAH",Descriptions=""}
                  , new Malls{Id=2,Title="AL RASHID MALL-JIZAN",Descriptions=""}
                  , new Malls{Id=3,Title="AL RASHID MALL-ABHA",Descriptions=""}
                 
              };

            return shoplist ;
        }
       

        // GET: api/Malls/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Malls
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Malls/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
