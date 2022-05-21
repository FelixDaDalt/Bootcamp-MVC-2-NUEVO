using Bootcamp_MVC_2_NUEVO.Datos;
using Bootcamp_MVC_2_NUEVO.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_MVC_2_NUEVO.Controllers
{
    public class CrudController : Controller
    {
        private readonly AplicacionDbContext _Context;

        public CrudController(AplicacionDbContext context)
        {
            _Context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Unidades> ListadoUnidades = _Context.unidades;
            return View(ListadoUnidades);
        }

        public IActionResult Agregar()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Agregar(Unidades nueva)
        {
            if (ModelState.IsValid) //Validamos el modelo
            {
                _Context.unidades.Add(nueva);
                _Context.SaveChanges();
                TempData["mensaje"] = "Se ha agregado la unidad";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Eliminar(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            // obtener el libro
            var unidadaborrar = _Context.unidades.Find(Id);
            if (unidadaborrar == null)
            {
                return NotFound();
            }
            return View(unidadaborrar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EliminarUnidades(int id)
        {
            var unidadaborrar = _Context.unidades.Find(id);

            if (id == null || id == 0)
            {
                return NotFound();
            }
            if (unidadaborrar == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _Context.unidades.Remove(unidadaborrar);
                _Context.SaveChanges();
                TempData["mensaje"] = "Se ha eliminado la unidad";
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        public IActionResult Editar(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            // obtener el libro
            var unidadeditar = _Context.unidades.Find(Id);
            if (unidadeditar == null)
            {
                return NotFound();
            }
            return View(unidadeditar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarUnidades(Unidades editar)
        {

            
            if (ModelState.IsValid)
            {
                _Context.unidades.Update(editar);
                _Context.SaveChanges();
                TempData["mensaje"] = "Se ha editado la unidad";
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}
