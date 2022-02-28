using Clarielpractica01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Clarielpractica01.Controllers
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
        //Importante sin una accion no tenemos vistas
        public IActionResult Ejercicio(double DatoN1, double DatoN2, double DatoN3) {
            Double resultado = DatoN1 + DatoN2 + DatoN3;

            ViewBag.DatoN1V = DatoN1;
            ViewBag.DatoN2V = DatoN2;
            ViewBag.DatoN3V = DatoN3;


            ViewBag.VariableAEnviar = resultado;
            return View();
        } 
        
    }
}