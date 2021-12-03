using Ejercicio02_12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio02_12.Controllers
{
    public class FacultadesController : Controller
    {
        Facultades facultad;
        List<Facultades> facultades;

        public FacultadesController()
        {
            facultades = new List<Facultades>();
            facultades.Add(new Facultades(0, "Enfermería", "Enfermeria"));
            facultades.Add(new Facultades(1, "Odontología", "Odontologia"));
            facultades.Add(new Facultades(2, "Ciencias Jurídicas y Políticas", "Derecho - Ciencia Politica y Gobierno"));
            facultades.Add(new Facultades(3, "Ciencias Farmacéuticas, Bioquímicas y Biotecnológicas", "Farmacia y Biouimica - Ingenieria Biotecnologica"));
            facultades.Add(new Facultades(4, "Ciencias e Ingenierías Biológicas y Químicas", "Ingenieria  Agronomica y Agricola - Medicina Veterinaria y Zootecnia - Ingenieria Industria Alimentaria"));
            facultades.Add(new Facultades(5, "Ciencias Económico Administrativas", "Administracion de Empresas - Ingenieria Comercial"));
            facultades.Add(new Facultades(6, "Medicina Humana", "Medicina Humana"));
            facultades.Add(new Facultades(7, "Ciencias e Ingenierías Físicas y Formales", "Ingenieria Electronica - Ingenieria Industrial - Ingenieria de Minas - Ingenieria Mecanica - Ingenieria de Sistemas"));
            facultades.Add(new Facultades(8, "Ciencias Contables y Financieras", "Contabilidad"));
            facultades.Add(new Facultades(9, "Obstetricia y Puericultura", "Obstetricia y Puericultura"));
            facultades.Add(new Facultades(10, "Ciencias y Tecnologías Sociales y Humanidades", "Publicidad y Multimedia - Comunicacion Social - Psicologia - Educacion - Trabajo Social - Teologia - Turismo y Hoteleria"));
            facultades.Add(new Facultades(11, "Arquitectura e Ingeniería Civil y del Ambiente", "Arquitectuca - Ingenieria Ambiental - Ingenieria Civil"));
        }

        public ActionResult Index()
        {
            Tuple<List<Facultades>, Facultades> tuple;
            tuple = new Tuple<List<Facultades>, Facultades>(facultades, facultades[2]);
            return View("Facultades", tuple);

        }
        [HttpPost]
        public ActionResult OnSelectFacult(string facultNumber)
        {
            Tuple<List<Facultades>, Facultades> tuple;
            tuple = new Tuple<List<Facultades>, Facultades>(facultades, facultades[Int32.Parse(facultNumber)]);
            return View("_FacultadesDetails", facultades[Int32.Parse(facultNumber)]);

        }
    }
}