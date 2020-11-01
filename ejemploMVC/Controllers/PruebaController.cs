using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejemploMVC.Models;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }
        //POST: PRUEBA/INDEX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Calculo obCalculo)
        {
            //Suma
            int resultado = obCalculo.numero1 + obCalculo.numero2;
            ViewBag.resultado = resultado;
            //Resta
            int resultadoResta = obCalculo.numero1 - obCalculo.numero2;
            ViewBag.resultadoResta = resultadoResta;
            //Multiplicacion
            int resultadoMulti = obCalculo.numero1 * obCalculo.numero2;
            ViewBag.resultadoMulti = resultadoMulti;
            //Divicion
            int resultadoDiv = obCalculo.numero1 / obCalculo.numero2;
            ViewBag.resultadoDiv = resultadoDiv;

            return View(obCalculo);
        }
    }
}
