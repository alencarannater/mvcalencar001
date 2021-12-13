using E_jogos.Models;
using System.Collections.Generic;

namespace E_jogos.Interface
{
    public interface IEquipe
    {
        void Crate(Equipe novaEquipe);

        List<Equipe> ReadAll();

        void Updade(Equipe equipe);

        void Delete (int id);
    }
}
