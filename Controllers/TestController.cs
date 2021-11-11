using Microsoft.AspNetCore.Mvc;

namespace TicketsApp.Orderding.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDoubledText(string text)
        {
            return Ok(text + text);
        }
    }
}
