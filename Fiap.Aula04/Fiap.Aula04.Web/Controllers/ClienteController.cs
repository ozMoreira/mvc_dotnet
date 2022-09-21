using Fiap.Aula04.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiap.Aula04.Web.Controllers
{
    public class ClienteController : Controller
    {
        private static List<Cliente> _listaCliente = new();
        private static int _id = 0;
        private static int _index;

        public void CarregaFormacao()
        {
            var lista = new List<String>(new String[] { "Fundamental", "Medio", "Superior" });
            ViewBag.formacoes = new SelectList(lista);
        }

        public IActionResult Index()
        {
            return View(_listaCliente);
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

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregaFormacao();
            _index = _listaCliente.FindIndex(c => c.Codigo == id);
            var cliente = _listaCliente[_index];
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(Cliente cliente)
        {
            _index = _listaCliente.FindIndex(c => c.Codigo == cliente.Codigo);
            _listaCliente[_index] = cliente;
            TempData["msg"] = "Cliente editado";
            return RedirectToAction("Editar");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            _listaCliente.RemoveAt(_listaCliente.FindIndex(c => c.Codigo == id));
            TempData["msg"] = "Cliente Excluido";
            return RedirectToAction("Index");
        }


    }
}
