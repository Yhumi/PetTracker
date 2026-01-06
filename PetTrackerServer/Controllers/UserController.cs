using Microsoft.AspNetCore.Mvc;
using PetTrackerServer.Models.Database;
using PetTrackerServer.Models.Registration;
using PetTrackerServer.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetTrackerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(UserService userService) : ControllerBase
    {
        [HttpGet("{privateId}")]
        public async Task<ActionResult<User>> GetUser(string privateId)
        {
            return null;
        }

        // POST api/<RegistrationController>
        [HttpPost]
        public async Task<ActionResult<User>> RegisterUser([FromBody] RegistrationModel registrationModel)
        {
            if (string.IsNullOrEmpty(registrationModel.Username) || string.IsNullOrEmpty(registrationModel.World))
                return BadRequest();

            var createUserResult = await userService.CreateUser(registrationModel);

            switch (createUserResult.response)
            {
                case Models.RegistrationResponse.Ok:
                    return Ok(createUserResult.user);
                case Models.RegistrationResponse.UserExists:
                    return BadRequest(createUserResult.message);
                case Models.RegistrationResponse.Error:
                default:
                    return Problem(detail: createUserResult.message);
            }
        }

        // DELETE api/<RegistrationController>/5
        [HttpDelete("{privateId}")]
        public void Delete(string privateId)
        {
        }
    }
}
