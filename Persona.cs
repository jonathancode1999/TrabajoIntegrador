using System;

namespace TrabajoIntegrador
{
    public class Persona
    {
        //Atributos
        private string nombre;
        private string dni;
        private int edad;

        //Propiedades
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

        //Constructor
        public Persona(string nombre, string dni, int edad)
        {
            Nombre = nombre;
            Dni = dni;
            Edad = edad;
        }
    }
}
