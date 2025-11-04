// Giovanne CB 3026591 / Ricardo CB3025543
// Projeto: Gerenciador de produtos
// CBTSWE2 - Trabalho Prático 03

using System.Diagnostics;
using GerProTP3.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerProTP3.Controllers
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
    }
}
