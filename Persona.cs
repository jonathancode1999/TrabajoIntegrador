using System;

namespace TrabajoIntegrador
{
    public class Persona
    {
        private string nombre;
        private string dni;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public Persona(string nombre, string dni, int edad)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.edad = edad;
        }
    }
}
