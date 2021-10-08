using System.Collections.Generic;
using AparClick.App.Dominio;
using System.Linq;


namespace AparClick.App.Persistencia//.AppRepositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly AppContext _appContext;
        public RepositorioCliente(AppContext appContext)
        {
            _appContext = appContext;
        }

        Cliente IRepositorioCliente.AddCliente(Cliente cliente)
        {
            var clienteAdicionado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }

        void IRepositorioCliente.DeleteCliente(int Id)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == Id);
            if (clienteEncontrado == null)
                return;
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Cliente> IRepositorioCliente.GetAllClientes()
        {
            return _appContext.Clientes;
        }

        Cliente IRepositorioCliente.GetCliente(int Id)
        {
            return _appContext.Clientes.FirstOrDefault(c => c.Id == Id);
        }

        Cliente IRepositorioCliente.UpdateCliente(Cliente cliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if (clienteEncontrado != null)
            {
                clienteEncontrado.Nombre = cliente.Nombre;
                clienteEncontrado.Apellidos = cliente.Apellidos;
                clienteEncontrado.FechaNacimiento = cliente.FechaNacimiento;
                clienteEncontrado.Celular = cliente.Celular;
                clienteEncontrado.Clave = cliente.Clave;
                clienteEncontrado.Genero = cliente.Genero;
                clienteEncontrado.Direccion = cliente.Direccion;
                clienteEncontrado.LicenciaConduccion = cliente.LicenciaConduccion;
                clienteEncontrado.Vehiculo = cliente.Vehiculo;
                

                _appContext.SaveChanges();


            }
            return clienteEncontrado;
        }

        /**Cliente IRepositorioCliente.AsignarVehiculo(int Id, int VehiculoId)
        {
            var clienteEncontrado = _appContext.Cliente.FirstOrDefault(c => c.Id == Id);
            if (clienteEncontrado != null)
            {
                var vehiculoEncontrado = _appContext.Vehiculo.FirstOrDefault(v => v.Id == VehiculoId);
                if (vehiculoEncontrado != null)
                {
                    clienteEncontrado.Vehiculo = vehiculoEncontrado;
                    _appContext.SaveChanges();
                }
                return vehiculoEncontrado;
            }
            return null;
        }**/


    }
}
