using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        // GET: api/<ActorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ActorController>/5
        [HttpGet("{strMovieName}")]
        public string Get(string strMovieName)
        {
            string strActorName = string.Empty;

            switch (strMovieName)
            {
                case "Terminator":
                    strActorName = "Arnold Schwarzenegger";
                    break;

                case "Superman":
                    strActorName = "Christopher Reeve";
                    break;

                case "Batman":
                    strActorName = "Christian Bale";
                    break;

                case "Spiderman":
                    strActorName = "Tobey Maguire";
                    break;

                case "Avengers":
                    strActorName = "Robert Downey jr";
                    break;
            }

            return strActorName;
        }

        // POST api/<ActorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ActorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ActorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
