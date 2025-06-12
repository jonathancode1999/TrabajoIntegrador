using System;
using System.Collections;

namespace TrabajoIntegrador
{
    public class Club
    {
        //Atributos
        private ArrayList entrenadores;
        private ArrayList deportes;

        //Constructor
        public Club()
        {
            entrenadores = new ArrayList();
            deportes = new ArrayList();
        }

        //Metodos para Entrenadores
        public void AgregarEntrenador(Entrenador e)
        {
            entrenadores.Add(e);
        }

        public void EliminarEntrenador(Entrenador e)
        {
            entrenadores.Remove(e);
        }

        public int CantidadEntrenadores()
        {
            return entrenadores.Count;
        }

        public bool ExisteEntrenador(Entrenador e)
        {
            return entrenadores.Contains(e);
        }

        public ArrayList VerEntrenadores()
        {
            return entrenadores;
        }

        public Entrenador RetornarEntrenador(int pos)
        {
            return (Entrenador)entrenadores[pos];
        }

        //Metodos para Deportes
        public void AgregarDeporte(Deporte d)
        {
            deportes.Add(d);
        }

        public void EliminarDeporte(Deporte d)
        {
            deportes.Remove(d);
        }

        public int CantidadDeportes()
        {
            return deportes.Count;
        }

        public bool ExisteDeporte(Deporte d)
        {
            return deportes.Contains(d);
        }

        public ArrayList VerDeportes()
        {
            return deportes;
        }

        public Deporte RetornarDeporte(int pos)
        {
            return (Deporte)deportes[pos];
        }
    }
}
