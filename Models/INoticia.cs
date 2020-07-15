using System.Collections.Generic;

namespace E_PlayersModel.Models
{
  public interface INoticias
    {
          //Criar
         void Criar(Noticias n);

         //Ler
         List<Noticias> Ler();

         //Alterar
         void Alterar(Noticias n);

         //Excluir
         void Deletar(Noticias n);
    }
}