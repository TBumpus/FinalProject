using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class MoviesController : Controller
    {
        // GET: MoviesController
        public ActionResult Index()
        {
            return View();
        }

    }
}
