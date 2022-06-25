using Microsoft.AspNetCore.Mvc;
using ProjektAspNetCore.Models;

namespace ProjektAspNetCore.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var model = new TestModel();
            model.Imie = "Paula";
            model.Nazwisko = "Wesołowska";
            return View(model);
        }
    }
}
