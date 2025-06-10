using System;
using System.Collections.Generic;

namespace TrabajoIntegrador
{
    class Program
    {
        static string[] CategoriasValidas = { "Infantil", "Cadete", "Juvenil", "Mayor" };

        static void Main()
        {
            Club club = new Club();
            int opcion;
            do
            {
                Console.WriteLine("----- Menu del Club Quilmes-----");
                Console.WriteLine("1. Alta de entrenador");
                Console.WriteLine("2. Baja de entrenador");
                Console.WriteLine("3. Alta de socio (inscripcion)");
                Console.WriteLine("4. Baja de socio");
                Console.WriteLine("5. Pago de cuota");
                Console.WriteLine("6. Submenu de inscripcion");
                Console.WriteLine("7. Listado de deudores");
                Console.WriteLine("8. Agregar deporte");
                Console.WriteLine("9. Eliminar deporte");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                try
                {
                    switch (opcion)
                    {
                        case 1:
                            AltaEntrenador(club);
                            break;
                        case 2:
                            BajaEntrenador(club);
                            break;
                        case 3:
                            AltaSocio(club);
                            break;
                        case 4:
                            BajaSocio(club);
                            break;
                        case 5:
                            PagarCuota(club);
                            break;
                        case 6:
                            ListadoDeInscriptos(club);
                            break;
                        case 7:
                            ListarDeudores(club);
                            break;
                        case 8:
                            AgregarDeporte(club);
                            break;
                        case 9:
                            EliminarDeporte(club);
                            break;
                        case 0:
                            Console.WriteLine("Nos vemos.");
                            break;
                        default:
                            Console.WriteLine("Opcion no valida.");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }

                Console.WriteLine();
            } while (opcion != 0);
        }

    }

    public class CategoriaInvalidaException : Exception
    {
        public CategoriaInvalidaException(string mensaje) : base(mensaje) { }
    }

    public class DeporteNoEncontradoException : Exception
    {
        public DeporteNoEncontradoException(string mensaje) : base(mensaje) { }
    }

    public class DiaInvalidoException : Exception
    {
        public DiaInvalidoException(string mensaje) : base(mensaje) { }
    }

    public class HorarioInvalidoException : Exception
    {
        public HorarioInvalidoException(string mensaje) : base(mensaje) { }
    }
}
