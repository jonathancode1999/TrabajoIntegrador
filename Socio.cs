using System;

namespace TrabajoIntegrador
{
    public class Socio : Persona
    {
        //Atributos
        private string deporte;
        private string categoria;
        private int ultimoMesPago;
        private double descuento;

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

        //Constructor
        //Como esta clase hereda de Persona, usamos sus atributos (nombre, dni y edad)
        //cuando creamos un objeto de tipo Socio

        public Socio(string nombre, string dni, int edad,string deporte, string categoria,int ultimoMesPago, double descuento): base(nombre, dni, edad)
        {
            Deporte = deporte;
            Categoria = categoria;
            UltimoMesPago = ultimoMesPago;
            Descuento = descuento;
        }

        //Metodo
        public double CalcularCuota(double cuotaBase)
        {
            //Calculamos la cuota restando el porcentaje de descuento, si es que tiene
            return cuotaBase - (cuotaBase * descuento / 100);
        }
    }
}
