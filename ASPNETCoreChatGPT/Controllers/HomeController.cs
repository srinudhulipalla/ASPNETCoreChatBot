using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreChatGPT.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
