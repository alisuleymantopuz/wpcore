using Microsoft.AspNetCore.Mvc;
namespace AspNetWebpack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}