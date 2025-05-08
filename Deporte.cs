using System.Collections.Generic;

namespace TrabajoIntegrador
{
    public class Deporte
    {
        //Atributos
        private string nombre;
        private string categoria;
        private Entrenador entrenador;
        private int cupo;
        private List<Socio> inscriptos;
        private double costoCuota;
        private string diasEntrenamiento;
        private string horarios;

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

        public List<Socio> Inscriptos
        {
            get { return inscriptos; }
            set { inscriptos = value; }
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
        public Deporte(string nombre, string categoria,Entrenador entrenador, int cupo,double costoCuota, string dias, string horarios)
        {
            Nombre = nombre;
            Categoria = categoria;
            Entrenador = entrenador;
            Cupo = cupo;
            CostoCuota = costoCuota;
            DiasEntrenamiento = dias;
            Horarios = horarios;
            inscriptos = new List<Socio>(); //Arrancamos con la lista vacia, sin socios anotados todavia
        }

        //mETODOS
        public bool HayCupo()
        {
            //Nos fijamos si la cantidad de inscriptos ya igualo el cupo
            return inscriptos.Count < cupo;
        }


        //inscribir un socio si es que todavia no esta inscripto
        public bool Inscribir(Socio s)
        {
            for (int i = 0; i < inscriptos.Count; i++)
                if (inscriptos[i].Dni == s.Dni) //ya existe
                    return false;

            if (!HayCupo()) //no hay mas lugar
                return false;

            inscriptos.Add(s); //lo agregamos a la lista
            return true;
        }

        //Dar de baja a un socio por su DNI
        public bool DarDeBaja(string dni)
        {
            for (int i = 0; i < inscriptos.Count; i++)
            {
                if (inscriptos[i].Dni == dni) //lo encontramos
                {
                    inscriptos.RemoveAt(i); //lo borramos de la lista
                    return true;
                }
            }
            return false; //no lo encontramos asi que retornamos falso
        }
    }
}
