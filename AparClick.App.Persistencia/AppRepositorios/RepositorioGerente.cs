using System.Collections.Generic;
using AparClick.App.Dominio;
using System.Linq;

namespace AparClick.App.Persistencia//.AppRepositorios
{

    public class RepositorioGerente : IRepositorioGerente
    {
        private readonly AppContext _appContext;

        public RepositorioGerente (AppContext appContext)
        {

            _appContext= appContext;
        }
        Gerente IRepositorioGerente.AddGerente (Gerente gerente)
        {
            var gerenteAdicionado = _appContext.Gerentes.Add(gerente);
            _appContext.SaveChanges();
            return gerenteAdicionado.Entity;
        }

        void IRepositorioGerente.DeleteGerente(int Id)
        {
            var gerenteEncontrado = _appContext.Gerentes.FirstOrDefault(g => g.Id == Id);
            if (gerenteEncontrado == null)
                return;
            _appContext.Gerentes.Remove(gerenteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Gerente> IRepositorioGerente.GetAllGerentes()
        {
            return _appContext.Gerentes;
        }

        Gerente IRepositorioGerente.GetGerente(int Id)
        {
            return _appContext.Gerentes.FirstOrDefault(g => g.Id == Id);
        }
         Gerente IRepositorioGerente.UpdateGerente(Gerente gerente)
        {
            var gerenteEncontrado = _appContext.Gerentes.FirstOrDefault(g => g.Id == gerente.Id);
            if ( gerenteEncontrado != null)
            {
                gerenteEncontrado.Nombre = gerente.Nombre;
                gerenteEncontrado.Apellidos = gerente.Apellidos;
                gerenteEncontrado.Correo = gerente.Correo;
                _appContext.SaveChanges();
            }
               return gerenteEncontrado;
        }
    }
}