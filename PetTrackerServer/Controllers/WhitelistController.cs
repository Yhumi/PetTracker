using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetTrackerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhitelistController : ControllerBase
    {
        // GET api/<WhitelistController>/5
        [HttpGet("{publicId}")]
        public string GetAllRequests(int publicId)
        {
            return "";
        }

        // POST api/<WhitelistController>
        [HttpPost]
        public void RequestToTrack([FromBody] string value)
        {

        }

        // PUT api/<WhitelistController>/5
        [HttpPut("accept/{publicId}")]
        public void Accept(int publicId)
        {
        }

        // DELETE api/<WhitelistController>/5
        [HttpDelete("delete/sub/{publicId}")]
        public void SubDelete(int publicId)
        {
        }

        // DELETE api/<WhitelistController>/5
        [HttpDelete("delete/dom/{privateId}")]
        public void DomDelete(int privateId)
        {
        }
    }
}
