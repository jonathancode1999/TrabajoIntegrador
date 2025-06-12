using System;
using System.Collections;

namespace TrabajoIntegrador
{
    class Program
    {
        static void Main(string[] args)
        {
            Club club = new Club();

            //Aca cree datos de pruebas para que cuando inicialice tenga datos por lo menos

            //Entrenadores
            Entrenador e1 = new Entrenador("Carlos", "111", 35, "futbol", "infantil");
            Entrenador e2 = new Entrenador("Lucía", "222", 40, "voley", "juvenil");
            Entrenador e3 = new Entrenador("Sofía", "333", 30, "handball", "cadete");
            Entrenador e4 = new Entrenador("Miguel", "444", 28, "hockey", "infantil");
            Entrenador e5 = new Entrenador("Elena", "555", 45, "natación", "juvenil");
            Entrenador e6 = new Entrenador("Jorge", "666", 33, "golf", "cadete");
            Entrenador e7 = new Entrenador("Laura", "777", 37, "tenis", "infantil");
            
            if (!club.ExisteEntrenador(e1)) 
                club.AgregarEntrenador(e1);
            if (!club.ExisteEntrenador(e2)) 
                club.AgregarEntrenador(e2);
            if (!club.ExisteEntrenador(e3)) 
                club.AgregarEntrenador(e3);
            if (!club.ExisteEntrenador(e4)) 
                club.AgregarEntrenador(e4);
            if (!club.ExisteEntrenador(e5)) 
                club.AgregarEntrenador(e5);
            if (!club.ExisteEntrenador(e6)) 
                club.AgregarEntrenador(e6);
            if (!club.ExisteEntrenador(e7)) 
                club.AgregarEntrenador(e7);

            //Deportes
            Deporte d1 = new Deporte("futbol", "infantil", e1, 5, 1500, "Lunes - Miercoles", "17:00 - 18:00");
            Deporte d2 = new Deporte("voley", "juvenil", e2, 4, 1800, "Martes - Jueves", "18:00 - 19:30");
            Deporte d3 = new Deporte("handball", "cadete", e3, 6, 1400, "Viernes - Sabado", "16:00 - 17:00");
            Deporte d4 = new Deporte("hockey", "infantil", e4, 3, 1600, "Lunes - Viernes", "19:00 - 20:00");
            Deporte d5 = new Deporte("natación", "juvenil", e5, 5, 2000, "Miercoles - Viernes", "20:00 - 21:30");
            Deporte d6 = new Deporte("golf", "cadete", e6, 4, 1300, "Martes - Jueves", "17:30 - 18:30");
            Deporte d7 = new Deporte("tenis", "infantil", e7, 2, 1700, "Sabado - Domingo", "10:00 - 11:30");

            if (!club.ExisteDeporte(d1)) 
                club.AgregarDeporte(d1);
            if (!club.ExisteDeporte(d2)) 
                club.AgregarDeporte(d2);
            if (!club.ExisteDeporte(d3)) 
                club.AgregarDeporte(d3);
            if (!club.ExisteDeporte(d4)) 
                club.AgregarDeporte(d4);
            if (!club.ExisteDeporte(d5)) 
                club.AgregarDeporte(d5);
            if (!club.ExisteDeporte(d6)) 
                club.AgregarDeporte(d6);
            if (!club.ExisteDeporte(d7)) 
                club.AgregarDeporte(d7);

            //Socios
            Socio s1 = new Socio("Juana", "444", 10, "futbol", "infantil", 3, 10);
            Socio s2 = new Socio("Pedro", "555", 11, "futbol", "infantil", 2, 5);
            Socio s3 = new Socio("Ana", "666", 17, "voley", "juvenil", 1, 20);
            Socio s4 = new Socio("Luis", "777", 9, "hockey", "infantil", 1, 8);
            Socio s5 = new Socio("Marta", "888", 16, "natación", "juvenil", 2, 15);
            Socio s6 = new Socio("Carlos", "999", 12, "golf", "cadete", 3, 12);
            Socio s7 = new Socio("Elena", "101", 10, "tenis", "infantil", 1, 7);
            Socio s8 = new Socio("Marina", "102", 11, "futbol", "infantil", 2, 6);
            Socio s9 = new Socio("Pablo", "103", 15, "voley", "juvenil", 3, 14);
            Socio s10 = new Socio("Sofía", "104", 10, "hockey", "infantil", 1, 9);
            Socio s11 = new Socio("Javier", "105", 17, "natación", "juvenil", 2, 16);
            Socio s12 = new Socio("Camila", "106", 13, "golf", "cadete", 1, 11);
            Socio s13 = new Socio("Diego", "107", 12, "futbol", "infantil", 3, 13);

            if (!d1.ExisteSocio(s1)) 
                d1.AgregarSocio(s1);
            if (!d1.ExisteSocio(s2)) 
                d1.AgregarSocio(s2);
            if (!d2.ExisteSocio(s3)) 
                d2.AgregarSocio(s3);
            if (!d4.ExisteSocio(s4)) 
                d4.AgregarSocio(s4);
            if (!d5.ExisteSocio(s5)) 
                d5.AgregarSocio(s5);
            if (!d6.ExisteSocio(s6)) 
                d6.AgregarSocio(s6);
            if (!d7.ExisteSocio(s7)) 
                d7.AgregarSocio(s7);
            if (!d1.ExisteSocio(s8)) 
                d1.AgregarSocio(s8);
            if (!d2.ExisteSocio(s9)) 
                d2.AgregarSocio(s9);
            if (!d4.ExisteSocio(s10)) 
                d4.AgregarSocio(s10);
            if (!d5.ExisteSocio(s11)) 
                d5.AgregarSocio(s11);
            if (!d6.ExisteSocio(s12)) 
                d6.AgregarSocio(s12);
            if (!d1.ExisteSocio(s13)) 
                d1.AgregarSocio(s13);



            int opcion;

            do
            {
                Console.WriteLine("\n----- Menu del Club RACING CLUB DE AVELLANEDA-----");
                Console.WriteLine("1. Agregar entrenador");
                Console.WriteLine("2. Eliminar entrenador");
                Console.WriteLine("3. Agregar socio");
                Console.WriteLine("4. Eliminar socio");
                Console.WriteLine("5. Pago de cuota");
                Console.WriteLine("6. Submenu de inscripcion");
                Console.WriteLine("7. Listado de deudores");
                Console.WriteLine("8. Agregar deporte");
                Console.WriteLine("9. Eliminar deporte");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                try
                {
                    switch (opcion)
                    {
                        case 1: 
                            AgregarEntrenador(club);
                            break;
                        case 2: 
                            EliminarEntrenador(club); 
                            break;
                        case 3: 
                            AgregarSocio(club); 
                            break;
                        case 4: 
                            EliminarSocio(club); 
                            break;
                        case 5: 
                            PagarCuota(club); 
                            break;
                        case 6: 
                            SubmenuInscripcion(club); 
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
                            Console.WriteLine("Gracias por usar Locademia System."); 
                            break;
                        default: 
                            Console.WriteLine("Opción invalida."); 
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            } while (opcion != 0);
        }

        static void PagarCuota(Club club)
        {
            Console.Write("DNI del socio: ");
            string dni = Console.ReadLine();
            Console.Write("Mes actual (1-12): ");
            int mes = int.Parse(Console.ReadLine());

            foreach (Deporte d in club.VerDeportes())
            {
                foreach (Socio s in d.VerSocios())
                {
                    if (s.Dni == dni)
                    {
                        if (s.UltimoMesPago < mes || (s.UltimoMesPago == 12 && mes == 1))
                        {
                            s.UltimoMesPago = mes;
                            Console.WriteLine($"Se genero el pago del socio del mes {mes}.");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("La cuota ya fue paga o ingreso mal el mes.");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("Socio no encontrado.");
        }

        static void SubmenuInscripcion(Club club)
        {
            Console.WriteLine("1. Ver inscriptos por deporte");
            Console.WriteLine("2. Ver inscriptos por deporte y categoría");
            Console.WriteLine("3. Ver todos los inscriptos");
            Console.Write("Seleccione una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el nombre del deporte: ");
                    string deporte = Console.ReadLine().ToLower();
                    foreach (Deporte d in club.VerDeportes())
                    {
                        if (d.Nombre.ToLower() == deporte)
                        {
                            Console.WriteLine($"{ d.Nombre} - { d.Categoria}");
                            foreach (Socio s in d.VerSocios())
                            {
                                Console.WriteLine("- " + s.Nombre);
                            }
                        }
                    }
                    break;

                case 2:
                    Console.Write("Ingrese el nombre del deporte: ");
                    string nom = Console.ReadLine().ToLower();
                    Console.Write("Ingrese la categoría: ");
                    string cat = Console.ReadLine().ToLower();
                    foreach (Deporte d in club.VerDeportes())
                    {
                        if (d.Nombre.ToLower() == nom && d.Categoria.ToLower() == cat)
                        {
                            Console.WriteLine($"{ d.Nombre} - { d.Categoria}");
                            foreach (Socio s in d.VerSocios())
                            {
                                Console.WriteLine("- " + s.Nombre);
                            }
                        }
                    }
                    break;

                case 3:
                    foreach (Deporte d in club.VerDeportes())
                    {
                        Console.WriteLine($"{ d.Nombre} - { d.Categoria}");
                        foreach (Socio s in d.VerSocios())
                        {
                            Console.WriteLine("- " + s.Nombre);
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }
        }

        static void ListarDeudores(Club club)
        {
            Console.Write("Mes actual (1-12): ");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("=====Socios deudores=====");

            foreach (Deporte d in club.VerDeportes())
            {
                foreach (Socio s in d.VerSocios())
                {
                    if (s.UltimoMesPago < mes || (s.UltimoMesPago == 12 && mes == 1))
                    {
                        Console.WriteLine($"{s.Nombre} (DNI: {s.Dni}) - Último mes pago: {s.UltimoMesPago}");
                    }
                }
            }
        }

        static void AgregarDeporte(Club club)
        {
            Console.Write("Nombre del deporte: ");
            string nombre = Console.ReadLine().ToLower();

            Console.Write("Categoría: ");
            string categoria = Console.ReadLine().ToLower();

            ArrayList entrenadores = club.VerEntrenadores();
            ArrayList disponibles = new ArrayList();

            foreach (Entrenador e in entrenadores)
            {
                if (e.Deporte.ToLower() == nombre && e.Categoria.ToLower() == categoria)
                {
                    disponibles.Add(e);
                }
            }

            if (disponibles.Count == 0)
            {
                Console.WriteLine("No existe ningun entrenador para ese deporte y categoria.");
                return;
            }

            Console.WriteLine("Entrenadores disponibles:");
            for (int i = 0; i < disponibles.Count; i++)
            {
                Entrenador e = (Entrenador)disponibles[i];
                Console.WriteLine((i + 1) + ". " + e.Nombre + " - DNI: " + e.Dni);
            }

            Console.Write("Seleccione un entrenador: ");
            int seleccion = int.Parse(Console.ReadLine()) - 1;
            if (seleccion < 0 || seleccion >= disponibles.Count)
            {
                Console.WriteLine("Ingreso un numero invalido.");
                return;
            }

            Entrenador entrenador = (Entrenador)disponibles[seleccion];

            Console.Write("Cupo maximo: ");
            int cupo = int.Parse(Console.ReadLine());

            Console.Write("Costo de la cuota: ");
            double cuota = double.Parse(Console.ReadLine());

            Console.Write("Dias de entrenamiento (ej: Lunes - Miércoles): ");
            string dias = Console.ReadLine();

            Console.Write("Horarios (ej: 17:00 - 18:00): ");
            string horario = Console.ReadLine();

            Deporte nuevo = new Deporte(nombre, categoria, entrenador, cupo, cuota, dias, horario);
            if (!club.ExisteDeporte(nuevo))
            {
                club.AgregarDeporte(nuevo);
                Console.WriteLine("Deporte agregado.");
            }
            else
            {
                Console.WriteLine("El deporte ya existe en esa categoría.");
            }
        }

        static void EliminarDeporte(Club club)
        {
            ArrayList deportes = club.VerDeportes();
            if (deportes.Count == 0)
            {
                Console.WriteLine("No hay deportes cargados.");
                return;
            }

            Console.WriteLine("Seleccione un deporte:");
            for (int i = 0; i < deportes.Count; i++)
            {
                Deporte d = (Deporte)deportes[i];
                Console.WriteLine((i + 1) + ". " + d.Nombre + " - " + d.Categoria);
            }

            Console.Write("Ingrese el numero del deporte a eliminar: ");
            int seleccion = int.Parse(Console.ReadLine()) - 1;

            if (seleccion >= 0 && seleccion < deportes.Count)
            {
                Deporte d = (Deporte)deportes[seleccion];
                if (d.CantidadSocios() == 0)
                {
                    club.EliminarDeporte(d);
                    Console.WriteLine("Deporte eliminado.");
                }
                else
                {
                    Console.WriteLine("No se puede eliminar. Hay socios inscriptos.");
                }
            }
            else
            {
                Console.WriteLine("Ingreso un numero fuera de rango.");
            }
        }

        static void AgregarSocio(Club club)
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("DNI: ");
            string dni = Console.ReadLine();

            Console.Write("Edad: ");
            string edadInput = Console.ReadLine();
            if (!int.TryParse(edadInput, out int edad))
                throw new EdadInvalidaException("Edad no válida. Ingrese un número entero.");

            string categoria;
            if (edad <= 12) 
                categoria = "infantil";
            else if (edad <= 15) 
                categoria = "cadete";
            else if (edad <= 18) 
                categoria = "juvenil";
            else 
                categoria = "mayor";

            Console.WriteLine($"Categoria seleccionada: {categoria.ToUpper()}");

            ArrayList deportes = club.VerDeportes();
            ArrayList disponibles = new ArrayList();

            for (int i = 0; i < deportes.Count; i++)
            {
                Deporte d = (Deporte)deportes[i];
                if (d.Categoria.ToLower() == categoria)
                    disponibles.Add(d);
            }

            if (disponibles.Count == 0)
            {
                Console.WriteLine("No hay deportes disponibles para esta categoría.");
                return;
            }

            Console.WriteLine("Seleccione un deporte:");
            for (int i = 0; i < disponibles.Count; i++)
            {
                Deporte d = (Deporte)disponibles[i];
                Console.WriteLine((i + 1) + ". " + d.Nombre + " - Cupo: " + d.Cupo);
            }

            Console.Write("Ingrese el numero del deporte: ");
            if (!int.TryParse(Console.ReadLine(), out int seleccion))
            {
                Console.WriteLine("No ingreso un numero valido.");
                return;
            }
            seleccion--;

            if (seleccion < 0 || seleccion >= disponibles.Count)
            {
                Console.WriteLine("Ingreso un nmero fuera del rango.");
                return;
            }

            Deporte deporte = (Deporte)disponibles[seleccion];

            Console.Write("Ultimo mes pago, ingrese entre estos numeros: (1-12): ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Descuento (%): ");
            double descuento = double.Parse(Console.ReadLine());

            Socio socio = new Socio(nombre, dni, edad, deporte.Nombre, categoria, mes, descuento);

            if (!deporte.ExisteSocio(socio) && deporte.CantidadSocios() < deporte.Cupo)
            {
                deporte.AgregarSocio(socio);
                Console.WriteLine("Socio inscripto correctamente.");
            }
            else
            {
                Console.WriteLine("No se pudo inscribir (ya existe o no hay cupo para el deporte de este entrenador).");
            }
        }

        static void EliminarSocio(Club club)
        {
            ArrayList deportes = club.VerDeportes();
            if (deportes.Count == 0)
            {
                Console.WriteLine("No hay deportes cargados.");
                return;
            }

            Console.WriteLine("Seleccione un deporte:");
            for (int i = 0; i < deportes.Count; i++)
            {
                Deporte d = (Deporte)deportes[i];
                Console.WriteLine((i + 1) + ". " + d.Nombre + " - " + d.Categoria);
            }

            Console.Write("Ingrese el numero del deporte: ");
            if (!int.TryParse(Console.ReadLine(), out int deporteIndex))
            {
                Console.WriteLine("No ingreso un numero valido.");
                return;
            }
            deporteIndex--;

            if (deporteIndex < 0 || deporteIndex >= deportes.Count)
            {
                Console.WriteLine("Ingreso un numero fuera del rango.");
                return;
            }

            Deporte deporte = (Deporte)deportes[deporteIndex];
            ArrayList socios = deporte.VerSocios();

            if (socios.Count == 0)
            {
                Console.WriteLine("No hay socios inscriptos en este deporte.");
                return;
            }

            Console.WriteLine("Seleccione un socio para eliminar:");
            for (int i = 0; i < socios.Count; i++)
            {
                Socio s = (Socio)socios[i];
                Console.WriteLine((i + 1) + ". " + s.Nombre + " - DNI: " + s.Dni);
            }

            Console.Write("Ingrese el numero del socio: ");
            if (!int.TryParse(Console.ReadLine(), out int socioIndex))
            {
                Console.WriteLine("No ingreso un numero valido.");
                return;
            }
            socioIndex--;

            if (socioIndex >= 0 && socioIndex < socios.Count)
            {
                deporte.EliminarSocio((Socio)socios[socioIndex]);
                Console.WriteLine("Socio eliminado.");
            }
            else
            {
                Console.WriteLine("Ingreso un numero fuera de rango.");
            }
        }

        static void AgregarEntrenador(Club club)
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("DNI: ");
            string dni = Console.ReadLine();

            Console.Write("Edad (Mayor a 18): ");
            string edadInput = Console.ReadLine();
            
            //Aca tuve que investigar un poco pero el TryParse trata de convertir el valor de edad a numero, si no es un numero tira la excepcion,
            //necesitamos si o si el out int edad para almacenar el valor si es que edadinput es un numero
            if (!int.TryParse(edadInput, out int edad))
                throw new EdadInvalidaException("Ingreso una edad no valida, solo numeros.");

            if (edad <= 18)
                throw new EdadInvalidaException("El entrenador debe ser mayor de 18 años.");

            Console.Write("Deporte: ");
            string deporte = Console.ReadLine();

            Console.Write("Categoría (Infantil/Cadete/Juvenil/Mayor): ");
            string categoria = Console.ReadLine().ToLower();
            string[] categoriasValidas = { "infantil", "cadete", "juvenil", "mayor" };

            bool valida = false;
            foreach (string cat in categoriasValidas)
            {
                if (categoria == cat)
                {
                    valida = true;
                    break;
                }
            }

            if (!valida)
                throw new CategoriaInvalidaException("No existe esa categoria. Usar: Infantil, Cadete, Juvenil o Mayor.");

            Entrenador entrenador = new Entrenador(nombre, dni, edad, deporte, categoria);
            if (!club.ExisteEntrenador(entrenador))
            {
                club.AgregarEntrenador(entrenador);
                Console.WriteLine("Entrenador agregado.");
            }
            else
            {
                Console.WriteLine("El entrenador ya existe.");
            }
        }

        static void EliminarEntrenador(Club club)
        {
            ArrayList entrenadores = club.VerEntrenadores();
            if (entrenadores.Count == 0)
            {
                Console.WriteLine("No se agregaron entrenadores todavia.");
                return;
            }

            for (int i = 0; i < entrenadores.Count; i++)
            {
                Entrenador e = (Entrenador)entrenadores[i];
                Console.WriteLine((i + 1) + ". " + e.Nombre + " - DNI: " + e.Dni);
            }

            Console.Write("Ingrese el numero del entranor que quiere borrar: ");

            //Aca tambien nos fijamos si que lo que el usuario pone en consola es un numero lo almacena en indice si no lo es tira el mensaje de error
            if (!int.TryParse(Console.ReadLine(), out int indice))
            {
                Console.WriteLine("No ingreso un numero valido.");
                return;
            }

            //Aca restamos el valor del indice para que sea un numero valido para el array, por ejemplo si ponemos 1, cuando lo resta queda en 0
            //Para que cuando vaya al array busque en la posicion 1
            indice--;
            if (indice >= 0 && indice < entrenadores.Count)
            {
                club.EliminarEntrenador((Entrenador)entrenadores[indice]);
                Console.WriteLine("Entrenador eliminado.");
            }
            else
            {
                Console.WriteLine("Numero fuera de rango.");
            }
        }

        //Clases para las exepciones
        public class EdadInvalidaException : Exception
        {
            public EdadInvalidaException(string mensaje) : base(mensaje) { }
        }

        public class CategoriaInvalidaException : Exception
        {
            public CategoriaInvalidaException(string mensaje) : base(mensaje) { }
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
}