using Proyecto3_Diplomado_Web_MVC_UASD_Registro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto3_Diplomado_Web_MVC_UASD_Registro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var coches = new List<Coche>()
            {
                new Coche(){ Tipo = "Jeep", Marca = "BMW", Modelo = "X6", Color = "Azul" },
                new Coche(){ Tipo = "Auto", Marca = "Mercedes", Modelo = "A200", Color = "Blanco" },
                new Coche(){ Tipo = "Jeep", Marca = "Porsche", Modelo = "Cayanne", Color = "Negro" },
                new Coche(){ Tipo = "Auto", Marca = "Ford", Modelo = "Mustang", Color = "Rojo" }
            };
            return View(coches);
        }

        public ActionResult Personas()
        {
            var personas = new List<Persona>()
            {
                new Persona(){ Nombre = "Juan", Apellido = "Santos", Direccion = "por ahi", Telefono = "809-522-6336" },
                new Persona(){ Nombre = "Pedro", Apellido = "Martinez", Direccion = "lejisimo", Telefono = "809-522-6336" },
                new Persona(){ Nombre = "Mario", Apellido = "Espinosa", Direccion = "bastante lejos", Telefono = "809-522-6336" },
                new Persona(){ Nombre = "Veneno", Apellido = "Perez", Direccion = "en pekin", Telefono = "809-522-6336" }
            };
            return View(personas);
        }
    }
}