using System.Collections.Generic;
using AparClick.App.Dominio;

namespace AparClick.App.Persistencia//.AppRepositorios
{
    public interface IRepositorioGerente
    {
        IEnumerable<Gerente> GetAllGerentes();

        Gerente AddGerente (Gerente gerente);

        Gerente UpdateGerente (Gerente gerente);

        void DeleteGerente (int Id);

        Gerente GetGerente (int Id);
        
    }

        
}