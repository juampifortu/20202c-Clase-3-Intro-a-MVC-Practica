using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABM_Alimento.Controllers
{
    public class AlimentosController : Controller
    {
        AlimentoServicio alimentoServicio = new AlimentoServicio();
        // GET: Alimento
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Alta()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DarAlta(Alimento alimento)
        {
            alimentoServicio.Alta(alimento);
            return RedirectToAction("Todos");
        }
        public ActionResult Todos()
        {
            List<Alimento> alimentos = alimentoServicio.Todos();
            return View(alimentos);
        }
        public ActionResult Editar(int id)
        {
            Alimento alimento = alimentoServicio.buscarPorId(id);
            return View(alimento);
        }
        [HttpPost]
        public ActionResult Editar(Alimento alimento)
        {
            alimentoServicio.Editar(alimento);
            return RedirectToAction("Todos");
        }
        public ActionResult Borrar(int id)
        {
            alimentoServicio.Borrar(id);
            return RedirectToAction("Todos");
        }
    }
}