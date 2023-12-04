using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class IsAliveController : ControllerBase
    {
        private readonly ILogger<IsAliveController> _logger;

        public IsAliveController(ILogger<IsAliveController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "IsAlive")]
        public bool GetIsAlive()
        {
            return true;
        }
    }
}
