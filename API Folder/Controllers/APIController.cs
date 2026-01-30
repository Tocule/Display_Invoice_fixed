
using Microsoft.AspNetCore.Mvc;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetData()
        {
            string result = "";

            if (!string.IsNullOrEmpty(result))
            {
                return Ok(new { message = "Data fetched", data = result });
            }

            return Ok(new { message = "No data available" });
        }
    }
}

