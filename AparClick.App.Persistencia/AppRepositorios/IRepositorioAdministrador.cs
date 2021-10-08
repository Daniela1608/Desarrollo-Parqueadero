using System;
using System.Collections.Generic;
using AparClick.App.Dominio;
using System.Linq;


namespace AparClick.App.Persistencia//.AppRepositorios
{

    public interface IRepositorioAdministrador
    {

        IEnumerable<Administrador> GetAllAdministradores();

        Administrador AddAdministrador (Administrador administrador);

        Administrador UpdateAdministrador (Administrador administrador);

        void DeleteAdministrador (int Id);

        Administrador GetAdministrador (int Id);
        
    }

    
    
}