using Bootcamp_MVC_2_NUEVO.Datos;
using Bootcamp_MVC_2_NUEVO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Helpers;

namespace Bootcamp_MVC_2_NUEVO.Controllers
{
    public class EditHomeController : Controller
    {
        private readonly AplicacionDbContext _Context;

        public EditHomeController(AplicacionDbContext context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
            int id = 1;
            var editarHome = _Context.home.Find(id);
            return View(editarHome);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Home config)
        {
            if (ModelState.IsValid)
            {
                _Context.home.Update(config);
                _Context.SaveChanges();
                TempData["mensaje"] = "Se ha editado el Home";
                return RedirectToAction("Index");

            }
            return View();
        }

    }
}
