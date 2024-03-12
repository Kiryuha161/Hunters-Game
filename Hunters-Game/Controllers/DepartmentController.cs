using Microsoft.AspNetCore.Mvc;

namespace Hunters_Game.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
