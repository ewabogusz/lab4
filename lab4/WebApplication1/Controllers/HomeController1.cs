using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class FilmController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
