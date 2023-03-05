using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        // Declaracion de variables
        // Se declara una variable privada para que solo la clase donde estoy la pueda utilizar
        private readonly ILogger<HomeController> _logger;
        private readonly string _Nombre;
        // Se crea un Constructor el cual se ejecuta al iniciar la aplicacion
        public HomeController(ILogger<HomeController> logger, string nombre = "Daniel")
        {
            _logger = logger;
            _Nombre = nombre;
        }

        public IActionResult Index()
        {
            ViewBag.Edad = 37;
            ViewBag.Nombre = _Nombre;
            return View("index", "Johanna Andrea");
        }

        public IActionResult Privacy()
        {
            ViewBag.Nombre = _Nombre;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}