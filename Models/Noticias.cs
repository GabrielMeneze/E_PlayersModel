using System;
using System.Collections.Generic;
using System.IO;

namespace E_PlayersModel.Models
{
    public class Noticias : EplayersBase, INoticias
    {

        
        public int IdNoticias { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Imagem { get; set; }

        private const string PATH = "DataBase/Noticias.csv";

        /// <summary>
        /// Cria pasta e arquivos
        /// </summary>
        public Noticias()
        {
            CreateFolderAndFile(PATH);
        }

        /// <summary>
        /// Organiza a ordem da linha que será criada no csv
        /// </summary>
        /// <param name="linhas"></param>
        /// <returns></returns>
        private string Preparar(Noticias n)
        {
            return $"{n.IdNoticias};{n.Titulo};{n.Texto};{n.Imagem}";
        }

        /// <summary>
        /// Cria linhas no csv
        /// </summary>
        /// <param name="n"></param>
        public void Criar(Noticias n)
        {
            string[] linha = {Preparar(n)};
            File.AppendAllLines(PATH, linha);
        }

        /// <summary>
        /// Le todas as linhas do Path
        /// </summary>
        /// <returns>O valor delas</returns>
        public List<Noticias> Ler()
        {
            List<Noticias> noticias = new List<Noticias>();

            string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Noticias noticias1 = new Noticias();
                noticias1.IdNoticias = Int32.Parse(linha[0]);
                noticias1.Titulo = (linha[1]);
                noticias1.Texto = (linha[2]);
                noticias1.Imagem = (linha[3]);

                noticias.Add(noticias1);
            }
            return noticias;
        }
        /// <summary>
        /// Altera linhas
        /// </summary>
        /// <param name="n"></param>
        public void Alterar(Noticias n)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == n.IdNoticias.ToString());
            linhas.Add(Preparar(n));
            RewriteCSV(PATH, linhas);
        }
        /// <summary>
        /// Deleta linhas do csv
        /// </summary>
        /// <param name="n"></param>
        public void Deletar(Noticias n)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == IdNoticias.ToString());
            RewriteCSV(PATH, linhas);
        }


    }
}