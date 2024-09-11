using Microsoft.AspNetCore.Mvc;

namespace CpmDemoApp.Controllers
{
    [Route("inbox")]
    public class InboxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
