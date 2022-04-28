using Microsoft.AspNetCore.Mvc;

namespace AzlanioBaseWebApp.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Diversion() // This Tell The File 
        {                                // Controller & File Name Has To Be The Same
            return View();
        }
        public IActionResult Placeholder()
        {
            return View();

        }

    }
}
