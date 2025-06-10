using System;
using System.Collections.Generic;

namespace TrabajoIntegrador
{
    public class Deporte
    {
        private string nombre;
        private string categoria;
        private Entrenador entrenador;
        private int cupo;
        private List<Socio> inscriptos;
        private double costoCuota;
        private string diasEntrenamiento;
        private string horarios;

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

        public List<Socio> Inscriptos
        {
            get { return inscriptos; }
        }

        public Deporte(string nombre, string categoria, Entrenador entrenador, int cupo, double costoCuota, string dias, string horarios)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.entrenador = entrenador;
            this.cupo = cupo;
            this.costoCuota = costoCuota;
            this.diasEntrenamiento = dias;
            this.horarios = horarios;
            this.inscriptos = new List<Socio>();
        }

        public bool AgregarSocio(Socio s)
        {
            for (int i = 0; i < inscriptos.Count; i++)
            {
                if (inscriptos[i].Dni == s.Dni)
                    return false;
            }
            if (inscriptos.Count >= cupo)
                return false;

            inscriptos.Add(s);
            return true;
        }

        public bool EliminarSocio(string dni)
        {
            for (int i = 0; i < inscriptos.Count; i++)
            {
                if (inscriptos[i].Dni == dni)
                {
                    inscriptos.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public int CantidadSocios()
        {
            return inscriptos.Count;
        }

        public Socio VerSocio(string dni)
        {
            for (int i = 0; i < inscriptos.Count; i++)
            {
                if (inscriptos[i].Dni == dni)
                    return inscriptos[i];
            }
            return null;
        }

        public List<Socio> TodosSocios()
        {
            return inscriptos;
        }
    }
}
