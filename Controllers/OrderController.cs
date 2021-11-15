using Microsoft.AspNetCore.Mvc;

namespace TicketsApp.Orderding.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetDoubledText(int id)
        {
            return Ok(id);
        }
    }
}
