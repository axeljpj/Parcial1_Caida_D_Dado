using Microsoft.AspNetCore.Mvc;
using Parcial1_Caida_D_Dado.Models;

namespace Parcial1_Caida_D_Dado.Controllers
{
    public class DadoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(CaidaModel obdado)
        {
            Random rnd = new Random();
            obdado.NumeroGenerado = rnd.Next(1, 50);
            return View("Resultado", obdado);
        }
    }
}
