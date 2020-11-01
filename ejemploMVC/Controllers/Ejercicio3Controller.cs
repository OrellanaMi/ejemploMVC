using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejemploMVC.Models;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class Ejercicio3Controller : Controller
    {
        // GET: Ejercicio3
        public ActionResult Ejercicio3()
        {
            return View();
        }
        //POST: PRUEBA/INDEX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ejercicio3(Notas obNotas)
        {
            double resultadoN = (obNotas.nota1 + obNotas.nota2 + obNotas.nota3) / 3;

            if (resultadoN == 10)
            {
                ViewBag.resultadoN = resultadoN + " Felicidades";
            }
            else if (resultadoN < 10 && resultadoN >= 7)
            {
                ViewBag.resultadoN = resultadoN + " Aprobado";
            }
            else if (resultadoN < 7 && resultadoN >= 4)
            {
                ViewBag.resultadoN = resultadoN + " Aplazado";
            }
            else if (resultadoN <= 4)
            {
                ViewBag.resultadoN = resultadoN + " Visite un tutor";
            }

            return View(obNotas);
        }
    }
}