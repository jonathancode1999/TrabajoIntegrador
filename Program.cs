using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        Socio socio;


            


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
                    case 1:
                        AltaEntrenador(club);
                        break;
                    case 2:
                        BajaEntrenador(club);
                        break;
                    case 3:AltaSocio(club);
                        break;
                    case 4:
                        BajaSocio(club);
                        break;
                    case 5:
                        PagoCuota(club);
                        break;
                    case 6:
                        SubMenuInscripciones(club);
                        break;
                    case 7:
                        ListDeudores(club);
                        break;
                    case 8:
                        AgregarDeport(club);
                        break;
                    case 9:
                        EliminarDeport(club);
                        break;  



                       


                        
                    case 10:
                        club.ImprimirEntrenadores();
                        break;
                    case 11:
                        club.ImprimirDeportes();
                        break;
                }









            }
            while (consulta !=0);

            static void AltaEntrenador(Club club)
            {
                string nombre, dni, categoria, deporte;
                int edad;


                Console.WriteLine("");
                Console.WriteLine("*************************");
                Console.WriteLine("AGREGAR ENTRENADOR");
                Console.Write("Nombre del entrenador: "); nombre = Console.ReadLine();
                Console.Write("DNI del entrenador: "); dni = Console.ReadLine();
                Console.Write("Edad (Debe ser mayor de 18): "); edad = int.Parse(Console.ReadLine());
                if(edad<=18)
                       throw new EdadInvalidaException("El entrenador debe ser mayor de 18.");
                Console.Write("Deporte del entrenador: "); deporte = Console.ReadLine();
                Console.WriteLine("Categorias: Infantil(<=12), Cadete (13-15), Juvenil (16-18), Mayor(>18)");
                Console.Write("Categoria: "); categoria = Console.ReadLine();

                Entrenador entrenadorMain = new Entrenador(nombre, dni, edad, categoria, deporte);
                
                if(club.AgregarEntrenador(entrenadorMain))
                    Console.WriteLine("Entrenador cargado con exito.");
                else
                    Console.WriteLine("El entrandor ya existe.");



            }

            static void BajaEntrenador(Club club)
            {
                Console.WriteLine("");
                Console.WriteLine("*******************************************");
                Console.Write("DNI del entrenador a Eliminar: ");
                string dni=Console.ReadLine();
                if (club.EliminarEntrenador(dni))
                    Console.WriteLine("Entrenador eliminado.");
                else
                    Console.WriteLine("No se encontro el entrenador.");

            }

            static void AltaSocio(Club club)
            {
                string nombre, dni, deporte, categoria;
                int edad, ultimoMesPago;
                double descuento;

                Console.WriteLine("");
                Console.WriteLine("**************************************");
                Console.Write("Nombre Socio: ");
                nombre = Console.ReadLine();
                Console.Write("Edad: ");
                edad=int.Parse(Console.ReadLine());
                Console.Write("DNI Socio: ");
                dni =Console.ReadLine();
                Console.Write("Deporte: ");
                deporte = Console.ReadLine();
                Console.Write("Categoria: ");
                categoria = Console.ReadLine();
                Console.Write("Ultimo Mes De Pago: ");
                ultimoMesPago=int.Parse(Console.ReadLine());
                Console.Write("Descuento de socio: ");
                descuento=double.Parse(Console.ReadLine());

                Socio socioMain = new Socio(nombre,dni,edad,deporte,categoria,ultimoMesPago,descuento);
                string resuiltado = club.InscribirSocio(socioMain);
                if (resuiltado == "OK")
                    Console.WriteLine("Socio Cargado con exito");
                else
                    Console.WriteLine(resuiltado);
                

            }

            static void BajaSocio(Club club)
            {
                string dni,deporte, categoria;

                Console.Write("DNI del socio: ");
                dni=Console.ReadLine();
                Console.Write("Deporte socio: ");
                deporte=Console.ReadLine();
                Console.Write("Categoria socio: ");
                categoria=Console.ReadLine();

                if (club.DarDeBajaSocio(dni, deporte, categoria))
                    Console.WriteLine("Socio Eliminado.");
                else
                    Console.WriteLine("No se encotro el socio");
            }

            static void PagoCuota(Club club)
            {
                Console.WriteLine("");
                Console.WriteLine("*******************************");

                string dni, deporte, categoria;
                int mes;
                
                
                

                Console.Write("DNI del socio: ");
                dni = Console.ReadLine();
                Console.Write("Deporte: ");
                deporte = Console.ReadLine();
                Console.WriteLine("Categorias: Infantil(<=12), Cadete (13-15), Juvenil (16-18), Mayor(>18)");
                Console.Write("Categoria: ");
                categoria = Console.ReadLine();
                Console.Write("Mes a pagar: ");
                mes=int.Parse(Console.ReadLine());


                if (club.RegistrarPago(dni, deporte, categoria, mes))
                    
                    Console.WriteLine("Pago Realizado.");
                else
                    Console.WriteLine("Error en el pago.");


            }

            static void SubMenuInscripciones(Club club)
            {
                int consulta;
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("*********************************");
                    Console.WriteLine("Listados de inscripciones: ");
                    Console.WriteLine("1- Por deporte");
                    Console.WriteLine("2- Por deporte y Categoria");
                    Console.WriteLine("3- Total");
                    Console.WriteLine("Ingrese Listado: "); consulta=int.Parse(Console.ReadLine());

                    switch(consulta)
                    {
                        case 1:
                            club.ListadoPorDeporte();
                            break;
                       case 2:
                            club.ListadoInscriptosPorDeporteYCategoria();

                            break;
                       case 3:
                            club.ImprimirInscriptos();
                            break;
 
                    }

                }
                while (true);
            }

            static void ListDeudores(Club club)
            {
                int mes;
                Console.WriteLine("");
                Console.WriteLine("***************************");
                Console.Write("Ingrese Mes a consultar: ");
                mes=int.Parse(Console.ReadLine());

                club.ListarDeudores(mes);

            }

            static void AgregarDeport(Club club)
            {
                string nombre, categoria, dias, horarios;
                int cupo;
                double costoCuota;
                List<Entrenador> entrenadores = club.ObtenerEntrenadores();
                Entrenador entrenadorEncontrado = null;

                Console.WriteLine("");
                Console.WriteLine("*******************************");
                Console.Write("Nombre del deporte: ");
                nombre=Console.ReadLine();

                foreach(Entrenador entrenador in entrenadores)
                {
                    if (entrenador.Nombre == nombre)
                    {
                       entrenadorEncontrado=entrenador;
                        break;
                    }
                }
                if(entrenadorEncontrado != null)
                {
                    Console.WriteLine($"Entrenador encontrado: {entrenadorEncontrado.Nombre}");
                }




                Console.Write("Categoria del deporte: ");
                categoria=Console.ReadLine();
                Console.Write("Dias que se dictan: ");
                dias=Console.ReadLine();
                Console.Write("Horarios que se dictan: ");
                horarios=Console.ReadLine();
                Console.Write("Limites de Cupos: ");
                cupo=int.Parse(Console.ReadLine());
                Console.Write("Costo de la cuota: ");
                costoCuota=double.Parse(Console.ReadLine());
                Console.WriteLine("");
                Deporte nuevoDeporte=new Deporte(nombre,categoria,entrenadorEncontrado,cupo,costoCuota,dias,horarios);
                club.AgregarDeporte(nuevoDeporte);






            }

            static void EliminarDeport(Club club)
            {
                string nombre, categoria;

                Console.WriteLine("");
                Console.WriteLine("***************************");
                Console.Write("Nombre del deporte a Eliminar: ");
                nombre=Console.ReadLine();
                Console.WriteLine("Categorias: Infantil(<=12), Cadete (13-15), Juvenil (16-18), Mayor(>18)");
                Console.Write("Categoria: ");
                categoria = Console.ReadLine();

                if (club.EliminarDeporte(nombre, categoria))
                {
                    Console.WriteLine("Deporte Eliminado con exito.");
                }
                else
                    Console.WriteLine("No se encontro el deporte.");

            }



        Console.WriteLine("TERMINO EL PROGRAMA"); }

       

        
    }

}



    
        


       






        













            
       
 
    

