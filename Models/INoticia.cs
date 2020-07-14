using System.Collections.Generic;

namespace E_PlayersModel.Models
{
  public interface INoticias
    {
          //Criar
         void Create(Noticias n);

         //Ler
         List<Noticias> ReadAll();

         //Alterar
         void Update(Noticias n);

         //Excluir
         void Delete(Noticias n);
    }
}