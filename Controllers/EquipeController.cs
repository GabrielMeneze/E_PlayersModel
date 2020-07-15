using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using E_PlayersModel.Models;
using Microsoft.AspNetCore.Http;

namespace E_PlayersModel.Controllers
{
    public class EquipeController : Controller
    {

        Equipe equipeModel = new Equipe();


        public IActionResult Index()
        {
            ViewBag.Equipes = equipeModel.Ler();
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();
            novaEquipe.IdEquipe = Int32.Parse( form["IdEquipe"] );
            novaEquipe.Nome = form["Nome"];
            novaEquipe.Imagem = form["Imagem"];

            equipeModel.Criar(novaEquipe);

            ViewBag.Equipes = equipeModel.Ler();
            return LocalRedirect("~/Equipe");
            
        }

    }
}
