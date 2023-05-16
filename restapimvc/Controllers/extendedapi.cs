using Microsoft.AspNetCore.Mvc;

namespace restapimvc.Controllers
{
    public class extendedapi : Controller
    {
        public IActionResult product()
        {
            return View();
        }
    }
}
