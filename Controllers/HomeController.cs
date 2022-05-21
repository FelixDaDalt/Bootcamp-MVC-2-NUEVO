using Bootcamp_MVC_2_NUEVO.Datos;
using Bootcamp_MVC_2_NUEVO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bootcamp_MVC_2_NUEVO.Controllers
{
    public class HomeController : Controller
    {
        private readonly AplicacionDbContext _Context;

        public HomeController(AplicacionDbContext context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Home> Configuracion = _Context.home;
            return View(Configuracion);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}