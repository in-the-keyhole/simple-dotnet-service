using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace simple_dotnet_service.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class HelloController : ControllerBase
    {

        // GET api/hello
        [HttpGet]
        public Response Get([FromQuery(Name = "name")] String name)
        {
            return new Response() { Greeting = "Hello " + name + " from .NET Core!"};
        }

        // POST api/hello
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/hello
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/hello
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
