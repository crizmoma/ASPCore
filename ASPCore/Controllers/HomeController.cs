using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPCore.Models;

namespace ASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            AlumnoModel AlumnoModel = new AlumnoModel();
            var a = AlumnoModel;
            var B = AlumnoModel;
            var C = AlumnoModel;


            a.Nombre = "Cristal";
            a.App = "Montlongo";
            a.Apm = "Maldonado";
            a.Carrera = "informática";
            a.FechaIngreso = "25 DE OCTUBRE 2020";
            a.NC = "17030096";
            a.Promedio = "9.5";


            B.NombreB = "Siria";
            B.AppB = "Montelongo";
            B.ApmB = "Maldonado";
            B.CarreraB = "Industrial";
            B.FechaIngresoB = "13 de Octubre 2020";
            B.NCB = "16b100211";
            B.PromedioB = "10";


            C.NombreC = "Alejandro";
            C.AppC = "chihuahua";
            C.ApmC = "Garcia";
            C.CarreraC = "Industrial";
            C.FechaIngresoC = "10 de Octubre 2020";
            C.NCC= "1234";
            C.PromedioC = "9.8";




            return View(AlumnoModel);

        }



        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
   