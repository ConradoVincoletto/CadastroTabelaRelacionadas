using Microsoft.AspNetCore.Mvc;

namespace CadastroTabelasRelacionadas.Controllers
{
    public class ImagensController : Controller
    {
        private string caminhoServidor;

        public ImagensController(IWebHostEnvironment sistema)
        {
            caminhoServidor = sistema.WebRootPath;
        }
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Upload(IFormFile foto)
        {
            string caminhoParaSalvarImagem = caminhoServidor + "//Imagem//";

            if ( ! Directory.Exists(caminhoParaSalvarImagem))
            {
                Directory.CreateDirectory(caminhoParaSalvarImagem);
            }
            return RedirectToAction("Upload");
        }
        
    }
}
