using Fiap.Aula04Refat.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiap.Aula04.Web.Controllers
{
    public class CarroController : Controller
    {
        private static List<Carro> _lista = new List<Carro>();
        private static int _id = 0;

        public IActionResult Index()
        {
            //TempData["lista"] = _lista;
            return View(_lista);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            //mockup de um recebimento de dados de uma requisição para o select
            CarregaMarcas();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Carro carro)
        {
            carro.IdCarro = ++_id;
            _lista.Add(carro);
            TempData["msg"] = "Carro Cadastrado!";
            //redireciona para o get de cadastrar, zerando os campos
            return RedirectToAction("Cadastrar");
        }

        private void CarregaMarcas()
        {
            var lista = new List<String>(new String[] { "Fiat", "Volkswagen", "Ford", "Chevrolet" });
            ViewBag.marcas = new SelectList(lista);
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregaMarcas();
            //Recuperar a posicao do carro na lista
            var index = _lista.FindIndex(c => c.IdCarro == id);
            //recuperar o carro atraves do id;
            var carro = _lista[index];
            //enviar o carro pra view
            return View(carro);
        }

        [HttpPost]
        public IActionResult Editar(Carro carro)
        {
            //Recuperar a posicao do carro na lista
            var index = _lista.FindIndex(c => c.IdCarro == carro.IdCarro);
            //recuperar o carro atraves do id;
            _lista[index] = carro;            
            TempData["msg"] = "Carro Editado!";
            //enviar o carro pra view
            return RedirectToAction("Editar");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            //busca o carro na lista atraves de seu id, pra pegar o index.
            _lista.RemoveAt(_lista.FindIndex(c => c.IdCarro == id));
            TempData["msg"] = "Carro Excluido!";
            return RedirectToAction("Index");
        }




    }
}
