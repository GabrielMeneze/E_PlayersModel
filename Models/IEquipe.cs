using System.Collections.Generic;

namespace E_PlayersModel.Models
{
    public interface IEquipe
    {
         void Criar(Equipe e);
         List<Equipe> Ler();
         void Alterar(Equipe e);
         void Excluir(int IdEquipe);
    }
}