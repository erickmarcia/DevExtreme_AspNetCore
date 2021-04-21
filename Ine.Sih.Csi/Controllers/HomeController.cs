using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ine_Sih_Csi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tablero()
        {
            return View();
        }
        public IActionResult Importaciones()
        {
            return View();
        }
        public IActionResult Petroleras()
        {
            return View();
        }
        public IActionResult PlantasGeneradoras()
        {
            return View();
        }
        public IActionResult PlantasEnvasadoras()
        {
            return View();
        }
        public IActionResult ProyeccionesCNDC()
        {
            return View();
        }
        public IActionResult Buques()
        {
            return View();
        }
        public IActionResult Puertos()
        {
            return View();
        }
        public IActionResult Estados()
        {
            return View();
        }
        public IActionResult Acerca() {
            return View();
        }
        public IActionResult Ayuda()
        {
            return View();
        }
        public IActionResult Viewer()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View();
        }
    }
}
