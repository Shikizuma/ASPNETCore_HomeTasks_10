using ASPNETCore_HomeTasks_10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace ASPNETCore_HomeTasks_10.Controllers
{
    public class HomeController : Controller
    {
        private ConfigModel _config;

        public HomeController(IOptionsSnapshot<ConfigModel> config)
        {
            _config = config.Value;
        }

        public IActionResult Index()
        {
            return Content(_config.Message);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}