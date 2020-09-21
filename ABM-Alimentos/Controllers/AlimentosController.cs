using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABM_Alimentos.Controllers
{
    public class AlimentosController : Controller
    {
        AlimentoServicio alimentoServicio = new AlimentoServicio();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DarDeAlta(Alimento alimento)
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
            Alimento alimento = alimentoServicio.BuscarPorId(id);
            return View(alimento);
        }

        
        [HttpPost]
        public ActionResult Editar(Alimento alimento)
        {
            alimentoServicio.Editar(alimento);
            return RedirectToAction("Todos");
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
