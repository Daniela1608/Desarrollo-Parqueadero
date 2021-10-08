using System;
using System.Collections.Generic;

namespace AparClick.App.Dominio
{
    public class Cliente : Persona
    {
        public string Direccion { get; set; }
        public string LicenciaConduccion { get; set; }
        public List<Vehiculo> Vehiculo { get; set;}

    }
}