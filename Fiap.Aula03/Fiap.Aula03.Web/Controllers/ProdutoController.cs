using Fiap.Aula03.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula03.Web.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            ViewData["chave"] = "Cadastro de Produto";
            ViewBag.subtitulo = "Aqui é uma viewbag de produtos";
            return View();
        }

        [HttpGet] //retorna a pagina com o form
        public IActionResult Cadastrar()
        {

            return View();
        }
        [HttpPost] //recebe os parametros do form
        public IActionResult Cadastrar(Produto produto)
        {
            /*
            //Enviar a descrição do produto para a view
            ViewData["desc"] = $"Descrição: {produto.Descricao}";
            ViewBag.valor = produto.Valor;
            return Content($"Descrição: {produto.Descricao}\n Valor: R$ {produto.Valor}");
            */
            //ViewBag.prod = produto; retorno para forward

            return View("Sucesso", produto);
        }

        public IActionResult Estoque()
        {
            return View();
        }
    }
}
