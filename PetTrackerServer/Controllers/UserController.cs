using Microsoft.AspNetCore.Mvc;
using PetTrackerServer.Models.Database;
using PetTrackerServer.Models.Registration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetTrackerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("{privateId}")]
        public User GetUser(string privateId)
        {

        }

        // POST api/<RegistrationController>
        [HttpPost]
        public User RegisterUser([FromBody] RegistrationModel registrationModel)
        {

        }

        // DELETE api/<RegistrationController>/5
        [HttpDelete("{privateId}")]
        public void Delete(string privateId)
        {
        }
    }
}
