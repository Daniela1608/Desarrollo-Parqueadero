using Microsoft.EntityFrameworkCore;
using AparClick.App.Dominio;


namespace AparClick.App.Persistencia//.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get;set;}
        public DbSet<Administrador> Administradores { get;set;}
        public DbSet<Auxiliar> Auxiliares { get;set;}
        public DbSet<Cliente> Clientes { get;set;}
        public DbSet<Gerente> Gerentes { get;set;}
        public DbSet<Reserva> Reservas { get;set;}
        public DbSet<Vehiculo> Vehiculos { get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AparClick11.Data");

        }
    }


    }
}

    