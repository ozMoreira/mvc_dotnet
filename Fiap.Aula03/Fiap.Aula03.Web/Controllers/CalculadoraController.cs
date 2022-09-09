using Fiap.Aula03.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula03.Web.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculadora calc)
        {
            switch (calc.Operacao)
            {
                case "+":
                    calc.Resultado = calc.Valor1 + calc.Valor2;
                    break;
                case "-":
                    calc.Resultado = calc.Valor1 - calc.Valor2;
                    break;
                case "*":
                    calc.Resultado = calc.Valor1 * calc.Valor2;
                    break;
                case "/":
                    try
                    {
                        calc.Resultado = calc.Valor1 / calc.Valor2;
                    }
                    catch (Exception)
                    {
                        calc.Resultado = 0;
                    }
                    
                    break;
                default:
                    calc.Resultado = 0;
                    break;
            }
            //ViewBag.Resultado = calc.Resultado; - so funciona com forward (encaminhamento)
            TempData["resultado"] = calc.Resultado;
            return RedirectToAction("Index");
        }
    }
}
