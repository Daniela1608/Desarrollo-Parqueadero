using System.Collections.Generic;
using AparClick.App.Dominio;
using System.Linq;

namespace AparClick.App.Persistencia//.AppRepositorios
{
    public interface IRepositorioCliente
    {
        IEnumerable<Cliente> GetAllClientes();
        Cliente AddCliente(Cliente cliente);
        Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente(int Id);
        Cliente GetCliente(int Id);
        //Vehiculo AsignarVehiculo(int Id, int VehiculoId);

    }
}