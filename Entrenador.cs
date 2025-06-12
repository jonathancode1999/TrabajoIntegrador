using System;

namespace TrabajoIntegrador
{
    public class Entrenador : Persona
    {
        //Atributos
        private string deporte;
        private string categoria;

        //Propiedades
        public string Deporte
        {
            get { return deporte; }
            set { deporte = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
    
        //Constructor
        public Entrenador(string nombre, string dni, int edad, string deporte, string categoria) : base(nombre, dni, edad)
        {
            this.deporte = deporte;
            this.categoria = categoria;
        }
    }
}
