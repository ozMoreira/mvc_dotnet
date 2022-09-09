using Fiap.Aula04.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula04.Web.Controllers
{
    public class CarroController : Controller
    {
        private static List<Carro> _lista = new List<Carro>();

        public IActionResult Index()
        {
            TempData["lista"] = _lista;
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Carro carro)
        {
            _lista.Add(carro); 
            TempData["msg"] = "Carro Cadastrado!";

            return View();
        }
    }
}
