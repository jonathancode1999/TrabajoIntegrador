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
        //Como esta clase hereda de Persona, usamos sus atributos (nombre, dni y edad)
        //cuando creamos un objeto de tipo Entrenador
        public Entrenador(string nombre, string dni, int edad, string deporte, string categoria): base(nombre, dni, edad)
        {
            Deporte = deporte;
            Categoria = categoria;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, DNI: {Dni}, Edad: {Edad}, Categoría: {Categoria}, Deporte: {Deporte}";
        }
    }
}
