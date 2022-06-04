using Microsoft.AspNetCore.Mvc;

namespace Dia17.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
