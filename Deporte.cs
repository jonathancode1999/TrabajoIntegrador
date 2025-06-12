using System;
using System.Collections;

namespace TrabajoIntegrador
{
    public class Deporte
    {
        //Atributos
        private string nombre;
        private string categoria;
        private Entrenador entrenador;
        private int cupo;
        private double costoCuota;
        private string diasEntrenamiento;
        private string horarios;
        private ArrayList inscriptos;

        //Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public Entrenador Entrenador
        {
            get { return entrenador; }
            set { entrenador = value; }
        }

        public int Cupo
        {
            get { return cupo; }
            set { cupo = value; }
        }

        public double CostoCuota
        {
            get { return costoCuota; }
            set { costoCuota = value; }
        }

        public string DiasEntrenamiento
        {
            get { return diasEntrenamiento; }
            set { diasEntrenamiento = value; }
        }

        public string Horarios
        {
            get { return horarios; }
            set { horarios = value; }
        }

        //Constructor
        public Deporte(string nombre, string categoria, Entrenador entrenador, int cupo, double costoCuota, string dias, string horarios)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.entrenador = entrenador;
            this.cupo = cupo;
            this.costoCuota = costoCuota;
            this.diasEntrenamiento = dias;
            this.horarios = horarios;
            this.inscriptos = new ArrayList();
        }

        //Metodos para Socios
        public void AgregarSocio(Socio s)
        {
            inscriptos.Add(s);
        }

        public void EliminarSocio(Socio s)
        {
            inscriptos.Remove(s);
        }

        public int CantidadSocios()
        {
            return inscriptos.Count;
        }

        public bool ExisteSocio(Socio s)
        {
            return inscriptos.Contains(s);
        }

        public ArrayList VerSocios()
        {
            return inscriptos;
        }

        public Socio RetornarSocio(int pos)
        {
            return (Socio)inscriptos[pos];
        }
    }
}
