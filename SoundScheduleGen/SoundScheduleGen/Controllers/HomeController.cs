using Microsoft.AspNetCore.Mvc;
using SoundScheduleGen.Models;
using System.Diagnostics;

namespace SoundScheduleGen.Controllers
{
    public class HomeController : Controller
    {
        #region private readonly properties
        private readonly ILogger<HomeController> _logger;
        #endregion

        #region Constructor and config
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        #endregion

        #region Actions
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}