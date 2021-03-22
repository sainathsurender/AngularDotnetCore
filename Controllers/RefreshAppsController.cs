using System.Threading.Tasks;
using Adminer.Models;
using Adminer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Adminer.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class RefreshAppsController : ControllerBase
    {
        private readonly ILogger<RefreshAppsController> _logger;
        private readonly IAdminService _adminService;

        public RefreshAppsController(ILogger<RefreshAppsController> logger,IAdminService adminService)
        {
            _adminService = adminService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetApplications()
        {
            return Ok(_adminService.GetApplicationsDB());
        }

        [HttpGet]
        public IActionResult GetEnvironments()
        {
            return Ok(_adminService.GetEnvironmentsDB());
        }

        [HttpPost]
        public async void RefreshApps(RefreshDTO refreshDTO)
        {
            Task.Delay(2000);
        }
    }
}
