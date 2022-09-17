using Fiap.Aula04.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiap.Aula04.Web.Controllers
{
    public class ClienteController : Controller
    {
        private static List<Cliente> _listaCliente = new();
        private static int _id = 0;

        public IActionResult Index()
        {
            return View();
        }

        public void CarregaFormacao()
        {
            var lista = new List<String>(new String[] {"Fundamental", "Medio", "Superior"});
            ViewBag.formacoes = new SelectList(lista);
        }

        public IActionResult Cadastrar()
        {
            CarregaFormacao();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cliente cliente)
        {
            cliente.Codigo = ++_id;
            _listaCliente.Add(cliente);
            TempData["msg"] = "Cliente Cadastrado!";
            return RedirectToAction("Cadastrar");

        }
    }
}
