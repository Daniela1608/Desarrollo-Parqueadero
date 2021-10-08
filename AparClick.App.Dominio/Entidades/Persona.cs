using System;
namespace AparClick.App.Dominio

{
    
    public class Persona
    {
        
        public int  Id { get;set; }
        public string Nombre { get;set; }
        public string Apellidos { get;set;}
        public DateTime FechaNacimiento { get;set;}
        public string Celular { get;set; }
		public string Correo { get;set; }
		public string Clave { get;set; }
		public Genero Genero { set;get; }

        
    }
}