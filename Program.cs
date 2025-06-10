
using System;
using System.Collections.Generic;
using TrabajoIntegrador;

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

    static string[] CategoriasValidas = { "Infantil", "Cadete", "Juvenil", "Mayor" };
    static void Main()
    {
        Club club = new Club();
        int opcion;
        do
        {
            Console.WriteLine("----- Menú del Club -----");
            Console.WriteLine("1. Alta de entrenador");
            Console.WriteLine("2. Baja de entrenador");
            Console.WriteLine("3. Alta de socio (inscripción)");
            Console.WriteLine("4. Baja de socio");
            Console.WriteLine("5. Pago de cuota");
            Console.WriteLine("6. Submenú de inscripción");
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
                        Console.WriteLine("Ni nos vimos perrito"); 
                        break;
                    default: 
                        Console.WriteLine("No existe esa opcion deficiente mental"); 
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

    static string DeterminarCategoria(int edad)
    {
        if (edad <= 12) return "Infantil";
        if (edad >= 13 && edad <= 15) return "Cadete";
        if (edad >= 16 && edad <= 18) return "Juvenil";
        if (edad > 18) return "Mayor";
        throw new EdadInvalidaException("Edad fuera de rango para las categorías.");
    }

    static int PedirMes(string contexto)
    {
        Console.Write($"Ingrese el mes {contexto} (1-12): ");
        int mes = int.Parse(Console.ReadLine());
        if (mes < 1 || mes > 12)
            throw new MesFueraDeRangoException("El mes debe estar entre 1 y 12.");
        return mes;
    }

    static double PedirDescuento()
    {
        Console.Write("Descuento (%): ");
        double d = double.Parse(Console.ReadLine());
        if (d < 0 || d > 100)
            throw new PorcentajeInvalidoException("El porcentaje debe estar entre 0 y 100.");
        return d;
    }

    static void AltaEntrenador(Club club)
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("DNI: ");
        string dni = Console.ReadLine();
        Console.Write("Edad (debe ser mayor de 18): ");
        int edad = int.Parse(Console.ReadLine());
        if (edad <= 18)
            throw new EdadInvalidaException("El entrenador debe tener más de 18 años.");
        Console.Write("Deporte: ");
        string deporte = Console.ReadLine().ToLower();
        Console.WriteLine("Categorías: Infantil (<=12), Cadete (13-15), Juvenil (16-18), Mayor (>18)");
        Console.Write("Categoría: ");
        string categoria = Console.ReadLine();

        Entrenador e = new Entrenador(nombre, dni, edad, deporte, categoria);
        if (club.AgregarEntrenador(e))
            Console.WriteLine("Entrenador agregado con éxito.");
        else
            Console.WriteLine("El entrenador ya existe.");
    }

    static void AltaSocio(Club club)
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("DNI: ");
        string dni = Console.ReadLine();
        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        string categoria = DeterminarCategoria(edad);
        Console.WriteLine($"Socio de categoría: {categoria}");

        // Mostrar deportes disponibles para su categoría
        List<Deporte> disponibles = club.Deportes.FindAll(d => d.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase));
        if (disponibles.Count == 0)
        {
            Console.WriteLine("No hay deportes disponibles para esta categoría.");
            return;
        }

        Console.WriteLine("Deportes disponibles:");
        foreach (var d in disponibles)
            Console.WriteLine($"- {d.Nombre}");

        Console.Write("Ingrese el nombre del deporte: ");
        string deporte = Console.ReadLine().ToLower();

        int ultimoMes = PedirMes("del último pago");
        double descuento = PedirDescuento();

        Socio s = new Socio(nombre, dni, edad, deporte, categoria, ultimoMes, descuento);
        if (club.InscribirSocio(s))
            Console.WriteLine("Socio inscripto con éxito.");
        else
            throw new CupoExcedidoException("No se pudo inscribir. Verifique edad, cupo o deporte.");
    }

    static void AgregarDeporte(Club club)
    {
        Console.Write("Nombre del deporte: ");
        string nombre = Console.ReadLine().ToLower();
        Console.WriteLine("Categorías: Infantil (<=12), Cadete (13-15), Juvenil (16-18), Mayor (>18)");
        Console.Write("Categoría: ");
        string categoria = Console.ReadLine();

        List<Entrenador> disponibles = club.Entrenadores.FindAll(e => e.Deporte.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (disponibles.Count == 0)
        {
            Console.WriteLine("No hay entrenadores disponibles para este deporte.");
            return;
        }

        Console.WriteLine("Entrenadores disponibles:");
        foreach (var e in disponibles)
            Console.WriteLine($"- {e.Nombre} (DNI: {e.Dni}) - Categoría: {e.Categoria}");

        Console.Write("Ingrese DNI del entrenador: ");
        string dniEntrenador = Console.ReadLine();
        Entrenador entrenador = disponibles.Find(e => e.Dni == dniEntrenador);
        if (entrenador == null)
        {
            Console.WriteLine("Entrenador no válido.");
            return;
        }

        Console.Write("Cupo máximo: ");
        int cupo = int.Parse(Console.ReadLine());
        Console.Write("Costo de la cuota: ");
        double costo = double.Parse(Console.ReadLine());
        Console.Write("Días de entrenamiento: ");
        string dias = Console.ReadLine();
        Console.Write("Horarios (formato HH:mm - HH:mm): ");
        string horarios = Console.ReadLine();

        Deporte d = new Deporte(nombre, categoria, entrenador, cupo, costo, dias, horarios);
        if (club.AgregarDeporte(d))
            Console.WriteLine("Deporte agregado con éxito.");
        else
            Console.WriteLine("Ese deporte ya existe.");
    }


    static string PedirCategoria()
    {
        while (true)
        {
            Console.Write("Categoría (Infantil/Cadete/Juvenil/Mayor): ");
            string input = Console.ReadLine();

            foreach (string cat in CategoriasValidas)
                if (cat.Equals(input, StringComparison.OrdinalIgnoreCase))
                    return cat;
            Console.WriteLine("Categoría inválida. Intente nuevamente.");
        }
    }

    static int PedirMes()
    {
        Console.Write("Mes (1-12): ");
        int mes = int.Parse(Console.ReadLine());
        if (mes < 1 || mes > 12)
            throw new MesFueraDeRangoException("El mes debe estar entre 1 y 12.");
        return mes;
    }

    static void BajaEntrenador(Club club)
    {
        Console.Write("DNI del entrenador: ");
        string dni = Console.ReadLine();
        if (club.EliminarEntrenador(dni))
            Console.WriteLine("Entrenador eliminado.");
        else
            Console.WriteLine("No se encontró el entrenador.");
    }


    static void BajaSocio(Club club)
    {
        Console.Write("DNI del socio: ");
        string dni = Console.ReadLine();
        Console.Write("Deporte: ");
        string deporte = Console.ReadLine();
        string categoria = PedirCategoria();

        if (club.DarDeBajaSocio(dni, deporte, categoria))
            Console.WriteLine("Socio dado de baja.");
        else
            throw new SocioNoEncontradoException("No se encontró al socio en ese deporte y categoría.");
    }

    static void PagarCuota(Club club)
    {
        Console.Write("DNI del socio: ");
        string dni = Console.ReadLine();
        Console.Write("Deporte: ");
        string deporte = Console.ReadLine();
        string categoria = PedirCategoria();
        int mes = PedirMes();

        if (club.RegistrarPago(dni, deporte, categoria, mes))
            Console.WriteLine("Pago registrado.");
        else
            Console.WriteLine("No se pudo registrar el pago.");
    }

    static void SubmenuInscripcion(Club club)
    {
        Console.WriteLine("1. Listar inscriptos por deporte");
        Console.WriteLine("2. Listar inscriptos por deporte y categoría");
        Console.WriteLine("3. Listar todos los inscriptos");
        Console.Write("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.Write("Deporte: ");
                string deporte = Console.ReadLine();
                foreach (Deporte d in club.Deportes)
                {
                    if (d.Nombre.Equals(deporte, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Categoría: {d.Categoria}");
                        foreach (Socio s in d.Inscriptos)
                            Console.WriteLine($"- {s.Nombre} (DNI: {s.Dni})");
                    }
                }
                break;
            case 2:
                Console.Write("Deporte: ");
                string dep = Console.ReadLine();
                string cat = PedirCategoria();
                Deporte deporteCat = club.BuscarDeporte(dep, cat);
                if (deporteCat != null)
                {
                    foreach (Socio s in deporteCat.Inscriptos)
                        Console.WriteLine($"- {s.Nombre} (DNI: {s.Dni})");
                }
                else
                {
                    Console.WriteLine("No se encontró el deporte/categoría.");
                }
                break;
            case 3:
                foreach (Deporte d in club.Deportes)
                {
                    Console.WriteLine($"Deporte: {d.Nombre} - Categoría: {d.Categoria}");
                    foreach (Socio s in d.Inscriptos)
                        Console.WriteLine($"- {s.Nombre} (DNI: {s.Dni})");
                }
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }

    static void ListarDeudores(Club club)
    {
        int mes = PedirMes();
        List<Socio> deudores = club.ListarDeudores(mes);
        if (deudores.Count == 0)
            Console.WriteLine("No hay deudores.");
        else
        {
            Console.WriteLine("Lista de deudores:");
            foreach (Socio s in deudores)
                Console.WriteLine($"- {s.Nombre} (DNI: {s.Dni}), Último mes pago: {s.UltimoMesPago}");
        }
    }

    static void EliminarDeporte(Club club)
    {
        Console.Write("Nombre del deporte: ");
        string nombre = Console.ReadLine();
        string categoria = PedirCategoria();

        if (club.EliminarDeporte(nombre, categoria))
            Console.WriteLine("Deporte eliminado.");
        else
            Console.WriteLine("No se pudo eliminar (puede tener inscriptos).");
    }
}
