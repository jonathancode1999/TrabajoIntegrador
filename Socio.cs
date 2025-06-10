using System;

namespace TrabajoIntegrador
{
    public class Socio : Persona
    {
        private string deporte;
        private string categoria;
        private int ultimoMesPago;
        private double descuento;

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

        public int UltimoMesPago
        {
            get { return ultimoMesPago; }
            set { ultimoMesPago = value; }
        }

        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        public Socio(string nombre, string dni, int edad, string deporte, string categoria, int ultimoMesPago, double descuento)
            : base(nombre, dni, edad)
        {
            this.deporte = deporte;
            this.categoria = categoria;
            this.ultimoMesPago = ultimoMesPago;
            this.descuento = descuento;
        }
    }
}
