using System;
using System.Collections.Generic;

namespace TrabajoIntegrador
{
    public class Club
    {
        private List<Deporte> deportes;
        private List<Entrenador> entrenadores;

        public Club()
        {
            deportes = new List<Deporte>();
            entrenadores = new List<Entrenador>();
        }

        // ================= ENTRENADORES =================
        public bool AgregarEntrenador(Entrenador e)
        {
            for (int i = 0; i < entrenadores.Count; i++)
            {
                if (entrenadores[i].Dni == e.Dni)
                    return false;
            }
            entrenadores.Add(e);
            return true;
        }

        public bool EliminarEntrenador(string dni)
        {
            for (int i = 0; i < entrenadores.Count; i++)
            {
                if (entrenadores[i].Dni == dni)
                {
                    entrenadores.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public int CantidadEntrenadores()
        {
            return entrenadores.Count;
        }

        public Entrenador VerEntrenador(string dni)
        {
            for (int i = 0; i < entrenadores.Count; i++)
            {
                if (entrenadores[i].Dni == dni)
                    return entrenadores[i];
            }
            return null;
        }

        public List<Entrenador> TodosEntrenadores()
        {
            return entrenadores;
        }

        // ================= DEPORTES =================
        public bool AgregarDeporte(Deporte d)
        {
            for (int i = 0; i < deportes.Count; i++)
            {
                if (deportes[i].Nombre == d.Nombre && deportes[i].Categoria == d.Categoria)
                    return false;
            }
            deportes.Add(d);
            return true;
        }

        public bool EliminarDeporte(string nombre, string categoria)
        {
            for (int i = 0; i < deportes.Count; i++)
            {
                if (deportes[i].Nombre == nombre && deportes[i].Categoria == categoria &&
                    deportes[i].Inscriptos.Count == 0)
                {
                    deportes.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public int CantidadDeportes()
        {
            return deportes.Count;
        }

        public Deporte VerDeporte(string nombre, string categoria)
        {
            for (int i = 0; i < deportes.Count; i++)
            {
                if (deportes[i].Nombre == nombre && deportes[i].Categoria == categoria)
                    return deportes[i];
            }
            return null;
        }

        public List<Deporte> TodosDeportes()
        {
            return deportes;
        }
    }
}
