using Microsoft.AspNetCore.Mvc;

namespace ProfTestium.Controllers
{
    public class PersonalAccount : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
