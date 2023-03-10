using HPCTechnical2023SpringMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HPCTechnical2023SpringMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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

        public IActionResult JsonTest()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> JsonTestResponse([FromBody] Document document)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                return Ok(ModelState);
            }
        }

    }
}