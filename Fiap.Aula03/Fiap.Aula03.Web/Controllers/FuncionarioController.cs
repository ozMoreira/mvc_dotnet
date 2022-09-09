using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula03.Web.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
