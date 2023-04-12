using Microsoft.AspNetCore.Mvc;

namespace CadastroTabelasRelacionadas.Controllers
{
    public class ImagensController : Controller
    {
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Upload()
        {
            return RedirectToAction("Upload");
        }
        
    }
}
