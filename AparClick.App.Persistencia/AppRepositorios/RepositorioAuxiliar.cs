using System.Collections.Generic;
using AparClick.App.Dominio;
using System.Linq;

namespace AparClick.App.Persistencia//.AppRepositorios
{

    public class RepositorioAuxiliar : IRepositorioAuxiliar
    {
        private readonly AppContext _appContext;

        public RepositorioAuxiliar (AppContext appContext)
        {

            _appContext= appContext;
        }
        Auxiliar IRepositorioAuxiliar.AddAuxiliar (Auxiliar auxiliar)
        {
            var auxiliarAdicionado = _appContext.Auxiliares.Add(auxiliar);
            _appContext.SaveChanges();
            return auxiliarAdicionado.Entity;
        }

        void IRepositorioAuxiliar.DeleteAuxiliar(int Id)
        {
            var auxiliarEncontrado = _appContext.Auxiliares.FirstOrDefault(x => x.Id == Id);
            if (auxiliarEncontrado == null)
                return;
            _appContext.Auxiliares.Remove(auxiliarEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Auxiliar> IRepositorioAuxiliar.GetAllAuxiliares()
        {
            return _appContext.Auxiliares;
        }

        Auxiliar IRepositorioAuxiliar.GetAuxiliar(int Id)
        {
            return _appContext.Auxiliares.FirstOrDefault(x => x.Id == Id);
        }

        Auxiliar IRepositorioAuxiliar.UpdateAuxiliar(Auxiliar auxiliar)
        {
            var auxiliarEncontrado= _appContext.Auxiliares.FirstOrDefault(x => x.Id == auxiliar.Id);
            if(auxiliarEncontrado!= null)
            {
                auxiliarEncontrado.Nombre = auxiliar.Nombre;
                auxiliarEncontrado.Apellidos = auxiliar.Apellidos;
                auxiliarEncontrado.Celular = auxiliar.Celular;
                auxiliarEncontrado.Correo = auxiliar.Correo;
                auxiliarEncontrado.Genero = auxiliar.Genero;
                auxiliarEncontrado.Clave = auxiliar.Clave;
                auxiliarEncontrado.FechaNacimiento = auxiliar.FechaNacimiento;
                auxiliarEncontrado.Turno = auxiliar.Turno;
                _appContext.SaveChanges();


            }
            return auxiliarEncontrado;
         }
    }



}    