using System;
using System.Collections.Generic;

namespace TrabajoIntegrador
{
    public class DeporteNoEncontradoException : Exception
    {
        public DeporteNoEncontradoException(string mensaje) : base(mensaje) { }
    }

    public class SocioNoEncontradoException : Exception
    {
        public SocioNoEncontradoException(string mensaje) : base(mensaje) { }
    }

    public class SocioYaExistenteException : Exception
    {
        public SocioYaExistenteException(string mensaje) : base(mensaje) { }
    }

    public class EdadInvalidaException : Exception
    {
        public EdadInvalidaException(string mensaje) : base(mensaje) { }
    }

    public class CupoExcedidoException : Exception
    {
        public CupoExcedidoException(string mensaje) : base(mensaje) { }
    }

    public class MesFueraDeRangoException : Exception
    {
        public MesFueraDeRangoException(string mensaje) : base(mensaje) { }
    }

    public class PorcentajeInvalidoException : Exception
    {
        public PorcentajeInvalidoException(string mensaje) : base(mensaje) { }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mauricio puto");
            Console.ReadKey();
        }
    }
}
