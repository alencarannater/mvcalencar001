using E_jogos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_jogos.Controllers
{
    public class EquipeController : Controller
    {
        Equipe equipeModel = new Equipe();



        //Representa o retorno do Status HTTP
        public IActionResult Index()
        {
            ViewBag.Equipes = equipeModel.ReadAll();

            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {


        }

    }
}
