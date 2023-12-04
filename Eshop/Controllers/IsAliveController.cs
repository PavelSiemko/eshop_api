using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class IsAliveController : ControllerBase
    {

        private readonly ILogger<IsAliveController> _logger;

        public IsAliveController(ILogger<IsAliveController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "IsAlive")]
        public bool Get()
        {
            return true;
        }
    }
}
