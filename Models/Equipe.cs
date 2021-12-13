using E_jogos.Interface;
using System.Collections.Generic;
using System.IO;

namespace E_jogos.Models
{
    public class Equipe : EjogosBase, IEquipe
    {
        private const string path = "Database/equipe.csv";
        public Equipe()
        {
            CreateFolderAndFile(path);
        }

        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }





        public void Crate(Equipe novaEquipe)
        {
            string [] linha = { $"{novaEquipe.IdEquipe};{novaEquipe.Nome};{novaEquipe.Imagem}" };

            File.AppendAllLines(path, linha);

        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Equipe> ReadAll()
        {
            List<Equipe> equipes = new List<Equipe> ();
            string[] linhas = File.ReadAllLines(path);
            foreach (string linha in linhas) {
                Equipe equipe = new Equipe();
                equipe.IdEquipe = int.Parse(linha.Split(';')[0]);
                equipe.Nome = (linha.Split(';')[1]);
                equipe.Imagem = (linha.Split(';')[2]);


                equipes.Add(equipe);
            }
            return equipes;
        }
            


        public void Updade(Equipe equipe)
        {
            throw new System.NotImplementedException();
        }
    }
}
