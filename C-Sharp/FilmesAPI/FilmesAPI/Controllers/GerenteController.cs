using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    public class GerenteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
