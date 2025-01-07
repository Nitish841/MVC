using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
