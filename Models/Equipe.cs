using System;
using System.Collections.Generic;
using System.IO;

namespace E_PlayersModel.Models
{
    public class Equipe : EplayersBase , IEquipe
    {
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        private const string PATH = "DataBase/equipe.csv";


        public Equipe()
        {
            CreateFolderAndFile(PATH);
        }

         public void Criar(Equipe e)
        {
            string[] linha = {PrepararLinha(e)};
            File.AppendAllLines(PATH,linha);
        }
         
           private string PrepararLinha(Equipe e)
           {
            return $"{e.IdEquipe};{e.Nome};{e.Imagem}";
           }


        public void Alterar(Equipe e)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == e.IdEquipe.ToString());
            linhas.Add(PrepararLinha(e));
            RewriteCSV(PATH, linhas);
        }
        
        public void Excluit(int IdEquipe)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == IdEquipe.ToString());
            RewriteCSV(PATH, linhas);
        }

        public List<Equipe> Ler()
        {
              List<Equipe> equipes = new List<Equipe>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Equipe equipe = new Equipe();
                equipe.IdEquipe = Int32.Parse(linha[0]);
                equipe.Nome = linha[1];
                equipe.Imagem = linha[2];

                equipes.Add(equipe);
            }
            return equipes;
        }
    }
}