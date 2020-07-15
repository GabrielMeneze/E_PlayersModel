using System;
using E_PlayersModel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_PlayersModel.Controllers
{
    public class NoticiaController : Controller
    {
    
        Noticias noticiasModel = new Noticias();
        public IActionResult Index()
        {
            ViewBag.Noticia = noticiasModel.ReadAll();
            return View();
        }
        public IActionResult Cadastrar(IFormCollection form)
        {
            Noticias novaNoticia  = new Noticias();
            novaNoticia.IdNoticia = Int32.Parse(  form["IdNoticia"]  );
            novaNoticia.Titulo    = form["Título"];
            novaNoticia.Texto     = form["Texto"];
            novaNoticia.Imagem    = form["Imagem"];

            noticiasModel.Create(novaNoticia);
            return LocalRedirect("~/Noticias");
        }

    }
}