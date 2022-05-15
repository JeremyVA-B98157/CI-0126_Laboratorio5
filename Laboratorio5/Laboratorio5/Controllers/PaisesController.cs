using Microsoft.AspNetCore.Mvc;
using Laboratorio5.Handlers;

namespace Laboratorio5.Controllers
{
    public class PaisesController : Controller
    {
        public IActionResult Index()
        {
            PaisesHandler paisesHandler = new PaisesHandler();
            var paises = paisesHandler.ObtenerPaises();
            ViewBag.MainTittle = paises;
            return View();
        }
    }
}
