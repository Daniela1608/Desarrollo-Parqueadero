using System;
namespace AparClick.App.Dominio
{
    public class Reserva  
    {

        public int ReservaId { get; set; }
        public DateTime FechaHoraIngreso { get;set; }
        public string Ubicacion { get;set; }
        public Cliente Cliente { get;set;}
        public Vehiculo Vehiculo { get; set;}

    }
}