using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejemploMVC.Models;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class Ejercicio2Controller : Controller
    {
        // GET: Ejercicio2
        public ActionResult Ejercicio2()
        {
            return View();
        }
        //POST: PRUEBA/INDEX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ejercicio2(conversion obConver)
        {
            /////temperatura
            double resultadoC = obConver.temperatura - 273.15;
            ViewBag.resultadoC = resultadoC;

            double resultadoK = obConver.temperatura + 273.15;
            ViewBag.resultadoK = resultadoK;

            ///Peso/////
            //kilos
            double resultadoKg = obConver.peso * 2.2;
            ViewBag.resultadoKg = resultadoKg;
            //libras
            double resultadolb = obConver.peso * 0.45;
            ViewBag.resultadolb = resultadolb;
            //longitud
            double resultadomt = obConver.longitud * 39.37;
            ViewBag.resultadomt = resultadomt;
            return View(obConver);
        }
    }
}