using System.Collections.Generic;
using AparClick.App.Dominio;

namespace AparClick.App.Persistencia//.AppRepositorios
{

    public interface IRepositorioAuxiliar
    {

        IEnumerable<Auxiliar> GetAllAuxiliares();

        Auxiliar AddAuxiliar (Auxiliar auxiliar);

        Auxiliar UpdateAuxiliar (Auxiliar auxiliar);

        void DeleteAuxiliar (int Id);

        Auxiliar GetAuxiliar (int Id);
        
    }

    
    
}