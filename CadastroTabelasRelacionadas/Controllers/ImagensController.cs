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
            try
            {
                string caminhoParaSalvarImagem = caminhoServidor + "\\imagem\\";
                string novoNomeParaImagem = Guid.NewGuid().ToString() + "_" + foto.FileName;

                Directory.CreateDirectory(caminhoParaSalvarImagem);

                using (var stream = System.IO.File.Create(caminhoParaSalvarImagem + novoNomeParaImagem))
                {
                    foto.CopyToAsync(stream);

                    TempData["MensagemSucesso"] = "Upload realizado com sucesso"; 
                }
                return RedirectToAction("Upload");
            }
            catch(Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, a foto não foi carregada, escolha um arquivo válido.";
                
            }
            return RedirectToAction("Upload");


        }
        
    }
}
