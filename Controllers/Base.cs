using Microsoft.AspNetCore.Mvc;

namespace TerraF.Controllers
{
    public class Base : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
