using Microsoft.AspNetCore.Mvc;

namespace CpmDemoApp.Controllers
{
    public class EmployeePortalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
