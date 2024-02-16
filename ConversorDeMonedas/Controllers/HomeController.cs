using ConversorDeMonedas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CapaLogicaNegocio.Dinero;
using CapaLogicaNegocio.Conversor;

namespace ConversorDeMonedas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OpcionConvertir opcionConvertir = new();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new Moneda());
        }

        [HttpPost]
        public IActionResult Index(Moneda moneda)
        {
            moneda = opcionConvertir.convertir(moneda);
            return View(moneda);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}