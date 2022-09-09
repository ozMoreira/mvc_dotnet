using Fiap.Aula03.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula03.Web.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastra()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastra(Usuario usuario)
        {
            if (usuario.Nome != null)
            {
                TempData["mensagem"] = "Cadastrado com Sucesso!";
                return View("Sucesso", usuario);
            }
            else
            {
                return View();
            }
           
            
        }
    }
}
