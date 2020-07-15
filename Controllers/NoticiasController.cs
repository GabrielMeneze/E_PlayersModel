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
    public class NoticiaController : Controller
    {
        Noticias noticiasModel = new Noticias();
          public IActionResult Index()
        {
            ViewBag.Equipes = noticiasModel.Ler();
            return View();
        }
    }

    


    
}