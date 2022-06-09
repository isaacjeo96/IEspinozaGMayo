using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class MateriaController : Controller
    {
        // GET: Materia
        public ActionResult GetAll()
        {
            ML.Materia materia = new ML.Materia();
            ML.Result result = BL.Materia.GetAll();
            if (result.Correct)
            {
                materia.Materias = result.Objects.ToList();
                return View(materia);
            }
            else
            {
                
                return View(materia);
            }
        }
        [HttpGet]
        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form(ML.Materia materia)
        {
            ML.Result result = BL.Materia.Add(materia);
            if (result.Correct)
            {
                ViewBag.Message = "Se registro correctamente la materia";
                return PartialView("Modal");
            }
            else
            {
                ViewBag.Message = "Ocurrio un error al insertar la materia" + result.ErrorMessage;
                return PartialView("Modal");
            }
            
        }
    }
}