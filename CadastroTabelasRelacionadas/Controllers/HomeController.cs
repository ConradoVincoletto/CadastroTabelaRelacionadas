using CadastroTabelasRelacionadas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CadastroTabelasRelacionadas.Controllers
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

        
    }
}