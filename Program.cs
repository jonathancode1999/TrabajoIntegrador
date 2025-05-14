using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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

    public class Program
    {
        public static void Main(string[] args)
        {
        List<Deporte> deportesMain=new List<Deporte>();
        List<Entrenador> entrenadorMain=new List<Entrenador>();
        Club club = new Club();
        


            int consulta;
            do
            {
                Console.WriteLine("************** BIENVENIDO AL CLUB ATLETICO BOCA JUNIORS *************");
                Console.WriteLine("1- Dar de alta a un entrenador");
                Console.WriteLine("2- Dar de baja a un entrenador");
                Console.WriteLine("3- Dar de alta a un niño/socio en un deporte");
                Console.WriteLine("4- Dar de baja a un niño/socio en un deporte");
                Console.WriteLine("5- Simular Pago de cuota");
                Console.WriteLine("6- Menu de inscripciones");
                Console.WriteLine("7- Lista de deudores");
                Console.WriteLine("8- Agregar un deporte");
                Console.WriteLine("9- Eliminar un deporte");
                Console.WriteLine("0- SALIR DE PROGRAMA");
                Console.Write("Ingrese Consulta: "); consulta = int.Parse(Console.ReadLine());


                switch (consulta)
                {
                    case 1: Console.WriteLine("AGREGAR ENTRENADOR");
                        
                        break;
                }









            }
            while (consulta !=0);



        Console.WriteLine("TERMINO EL PROGRAMA"); }


       

        
        
    }

}



    
        


       






        













            
       
 
    

