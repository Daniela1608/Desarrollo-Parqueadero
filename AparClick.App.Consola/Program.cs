using System;
using AparClick.App.Dominio;
using AparClick.App.Persistencia;
using System.Collections.Generic;





namespace AparClick.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente  = new RepositorioCliente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddCliente();
            BuscarCliente(1);
            
        }

        private static void AddCliente()
        {
            var cliente = new Cliente
            {
                Nombre = "Karol",
                Apellidos = "Pino",
                FechaNacimiento = new DateTime(1985, 10, 16),
                Celular = "3102692986",
                Clave = "123456",
                Genero = Genero.Femenino,
                Direccion = "Calle 10 Oeste # 15-300",
                LicenciaConduccion = "6985423113"
            };
            _repoCliente.AddCliente(cliente);
        }

        private static void BuscarCliente(int Id)
        {
            var cliente = _repoCliente.GetCliente(Id);
            Console.WriteLine(cliente.Nombre+" "+cliente.Apellidos);
        }               

    }
}
