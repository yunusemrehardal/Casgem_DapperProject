using Microsoft.AspNetCore.Mvc;

namespace Casgem_DapperProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
