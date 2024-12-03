using Microsoft.AspNetCore.Mvc;

namespace DrawPicture.Controllers
{
    public class DrawingPictureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
