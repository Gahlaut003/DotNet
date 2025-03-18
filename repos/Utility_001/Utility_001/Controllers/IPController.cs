using Microsoft.AspNetCore.Mvc;
using Utility_001.Repository;
using Utility_001.Services;
using Utility_001.Models;

namespace Utility_001.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IPController : Controller
    {
      //  private ISampleIPRepository _repository;

        private readonly ISampleIPService _ipsampleService;
        public IPController(ISampleIPService ipsampletService)
        {
            _ipsampleService = ipsampletService;
        }

        [HttpGet("GetAllIPs")]
        public IActionResult GetProducts()
        {
            var ipdata = _ipsampleService.GetAllIP();
            return Ok(ipdata);
        }

        [HttpPost("AddIPs")]
        public IActionResult AddProducts(SampleIPModel sampleIPModel)
        {
            var ipdata = _ipsampleService.AddIP( sampleIPModel);
            return Ok(ipdata);
        }
        /*        public IActionResult Index()
                {
                    return View();
                }*/
    }
}
