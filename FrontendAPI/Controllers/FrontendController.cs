using Microsoft.AspNetCore.Mvc;

namespace FrontendAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FrontendController : ControllerBase
    {
       
        private readonly ILogger<FrontendController> _logger;

        public FrontendController(ILogger<FrontendController> logger)
        {
            _logger = logger;
        }

        [HttpGet("test")]
        public async Task<string> Get()
        {
            return await Task.FromResult("Frontend API is running healthy");
        }
    }
}
