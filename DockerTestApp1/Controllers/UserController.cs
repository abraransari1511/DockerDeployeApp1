using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerTestApp1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DockerTestApp1.Controllers
{

    [ApiVersion("1.0")]
    [Route("api/v{v:apiVersion}/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IOptions<MySettingsConfiguration> _configuration;

        private User[] users = new User[]
     {
        new User { id = 1, name = "Haleemah Redfern", email = "email1@mail.com", phone = "01111111", role = 1},
        new User { id = 2, name = "Aya Bostock", email = "email2@mail.com", phone = "01111111", role = 1},
        new User { id = 3, name = "Sohail Perez", email = "email3@mail.com", phone = "01111111", role = 1},
        new User { id = 4, name = "Merryn Peck", email = "email4@mail.com", phone = "01111111", role = 2},
        new User { id = 5, name = "Cairon Reynolds", email = "email5@mail.com", phone = "01111111", role = 3}
     };

        public UserController(IOptions<MySettingsConfiguration> configuration)
        {
            _configuration = configuration;
        }

        // GET: api/Users
        //[ResponseType(typeof(IEnumerable<User>))]
        //[Route("List")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(users);
        }
        // GET: api/Users/5
        // [Route("getbyuserid")]
        [HttpGet("getbyuserid")]
        public IActionResult getbyuserid([FromQuery] int id)
        {
            var product = users.FirstOrDefault((p) => p.id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet("GetEnvironmentValue")]
        public IActionResult GetEnvironmentValue()
        {

         //   var customVariable = Environment.GetEnvironmentVariable("MyCustomVariable");
           // return Ok(customVariable);
            return Ok(_configuration.Value);
        }

        [HttpGet("GetCustomEnvironmentValue")]
        public IActionResult GetCustomEnvironmentValue()
        {

            var customVariable = Environment.GetEnvironmentVariable("MyCustomVariable");
            return Ok(customVariable);
        }
    }
}
