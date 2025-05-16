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
        
        
        Club club = new Club();
        

            string nombre, dni, categoria, deporte;
            int edad;


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
                    case 1: Console.WriteLine("*************************");
                        Console.WriteLine("AGREGAR ENTRENADOR");
                        Console.Write("Nombre del entrenador: "); nombre=Console.ReadLine();
                        Console.Write("DNI del entrenador: "); dni=Console.ReadLine();
                        Console.Write("Edad del entrenador: "); edad=int.Parse(Console.ReadLine());
                        Console.Write("Categoria del entrenador: "); categoria=Console.ReadLine();
                        Console.Write("Deporte del entrenador: "); deporte=Console.ReadLine();
                        Entrenador entrenadorMain=new Entrenador(nombre, dni,edad, categoria, deporte);
                        club.AgregarEntrenador(entrenadorMain);

                        
                        break;
                    case 2:
                        Console.WriteLine("*************************");
                       

                        if(club.Entrenadores.Count == 0)
                        {
                            Console.WriteLine("NO hay entrenadores cargados");
                        }
                        else
                        {
                            Console.WriteLine("DNI del entrenador a eliminar: ");
                            dni = Console.ReadLine();

                            bool eliminado = false;

                            for (int i = 0; i < club.Entrenadores.Count; i++)
                            {
                                if (club.Entrenadores[i].Dni == dni)
                                {
                                    club.EliminarEntrenador(dni);
                                    eliminado = true;

                                   
                                }
                                if (eliminado)
                                    Console.WriteLine("ELIMINADO CON EXITO");
                                else
                                    Console.WriteLine("NO SE ENCONTRO NINGUN ENTRENADOR CON ESE DNI");
                            }
                        }
                        break;

                           
                       


                        break;
                    case 3:
                        club.ImprimirEntrenadores();
                        break;
                }









            }
            while (consulta !=0);



        Console.WriteLine("TERMINO EL PROGRAMA"); }


       

        
        
    }

}



    
        


       






        













            
       
 
    

