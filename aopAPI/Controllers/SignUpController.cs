using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
