using System;
using System.Collections.Generic;
using AparClick.App.Dominio;
using System.Linq;

namespace AparClick.App.Persistencia//.AppRepositorios
{

    public class RepositorioAdministrador: IRepositorioAdministrador
    {

        private readonly AppContext _appContext;

        public RepositorioAdministrador(AppContext appContext)
        {
            _appContext= appContext;

        }
        Administrador IRepositorioAdministrador.AddAdministrador(Administrador administrador)
        {
            var administradorAdicionado = _appContext.Administradores.Add(administrador);
            _appContext.SaveChanges();
            return administradorAdicionado.Entity;
        }

        void IRepositorioAdministrador.DeleteAdministrador(int Id)
        {
            var administradorEncontrado = _appContext.Administradores.FirstOrDefault(a => a.Id == Id);
            if (administradorEncontrado == null)
                return;
            _appContext.Administradores.Remove(administradorEncontrado);
            _appContext.SaveChanges();

        }

        
        IEnumerable<Administrador> IRepositorioAdministrador.GetAllAdministradores()
        {
        
            return _appContext.Administradores;
                
        }

        Administrador IRepositorioAdministrador.GetAdministrador(int Id)
        {
            return _appContext.Administradores.FirstOrDefault(a => a.Id == Id);
        }

        Administrador IRepositorioAdministrador.UpdateAdministrador(Administrador administrador)
        {
            var administradorEncontrado = _appContext.Administradores.FirstOrDefault(a => a.Id == administrador.Id);
            if ( administradorEncontrado != null)
            {

                administradorEncontrado.Nombre = administrador.Nombre;
                administradorEncontrado.Apellidos = administrador.Apellidos;
                administradorEncontrado.Celular = administrador.Celular;
                administradorEncontrado.Correo = administrador.Correo;
                administradorEncontrado.Genero = administrador.Genero;
                administradorEncontrado.Clave = administrador.Clave;
                administradorEncontrado.FechaNacimiento = administrador.FechaNacimiento;
                administradorEncontrado.Cargo = administrador.Cargo;
                administradorEncontrado.HorasLaborales = administrador.HorasLaborales;
                _appContext.SaveChanges();




            }
            return administradorEncontrado;
        }


    }
}
