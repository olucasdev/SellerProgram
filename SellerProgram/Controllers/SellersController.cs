using Microsoft.AspNetCore.Mvc;

namespace SellerProgram.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
