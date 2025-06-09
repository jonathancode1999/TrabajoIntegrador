using System.Collections.Generic;

namespace TrabajoIntegrador
{
    public class Club
    {
        //Atributos de listas con los deportes y entrenadores
        private List<Deporte> deportes;
        private List<Entrenador> entrenadores;
        private List<Socio> socio;
        private double descuento;

        //Propiedades para poder acceder a la listas
        public List<Deporte> Deportes
        {
            get { return deportes; }
            set { deportes = value; }
        }

        public List<Entrenador> Entrenadores
        {
            get { return entrenadores; }
            set { entrenadores = value; }
        }

        //Constructor
        public Club()
        {
            //Inicializamos las listas vacias
            deportes = new List<Deporte>();
            entrenadores = new List<Entrenador>();
        }

        //Metodo
        //Agregar un entrenador si no existe
        public bool AgregarEntrenador(Entrenador e)
        {
            //Recorremos los entrenadores para verificar que no exista
            for (int i = 0; i < entrenadores.Count; i++)
                if (entrenadores[i].Dni == e.Dni) //ya existe el qliado
                    return false;

            entrenadores.Add(e); //Si no existe lo agrefamos
            return true;
        }

        public string Consulta(Deporte d)
        {
            //Cod para ver de mas y cosas ambientadas
            

            
        }

        public List<Entrenador> ObtenerEntrenadores()
        {
            return entrenadores;
        }

        public Entrenador BuscarEntrenadorPorDeporte(string deporte)
        {
            foreach (Entrenador e in entrenadores)
            {
                if (e.Deporte.Equals(deporte, StringComparison.OrdinalIgnoreCase))
                    return e;
            }
            return null; // No se encontró un entrenador para ese deporte
        }

        //Eliminar un entrenador por su DNI
        public bool EliminarEntrenador(string dni)
        {
            for (int i = 0; i < entrenadores.Count; i++)
            {
                if (entrenadores[i].Dni == dni)
                {
                    entrenadores.RemoveAt(i); //Lo eliminamos de la lista
                    return true;
                }
            }
            return false; //No se encontró el entrenador
        }

        //Agregar un deporte si no existe
        public bool AgregarDeporte(Deporte d)
        {
            for (int i = 0; i < deportes.Count; i++)
            {
                if (deportes[i].Nombre == d.Nombre) //Ya existe un deporte con ese nombre
                    return false;
            }

            deportes.Add(d); //Si no existe, lo agregamos
            return true;
        }
        public void ImprimirDeportes()
        {
            foreach (var deporte in deportes)
            {
                Console.WriteLine(deporte);
            }
        }

        //Eliminar un deporte, si es que el deporte no tiene socios
        public bool EliminarDeporte(string nombre, string categoria)
        {
            for (int i = 0; i < deportes.Count; i++)
            {
                if (deportes[i].Nombre == nombre && deportes[i].Categoria == categoria
                    && deportes[i].Inscriptos.Count == 0) //Nos fijamos si este deporte no tiene socios antes de eliminarlo de la lista
                {
                    deportes.RemoveAt(i); //Eliminamos el deporte ya que no tiene socios
                    return true;
                }
            }
            return false; //No se pudo eliminar porque tiene socios en ese deporte
        }

        //Buscar un deporte por su nombre y categoría
        public Deporte BuscarDeporte(string nombre, string categoria)
        {
            for (int i = 0; i < deportes.Count; i++)
            {
                if (deportes[i].Nombre == nombre && deportes[i].Categoria == categoria)
                {
                    return deportes[i]; //Retornamos el deporte que coincide con las propiedades
                }
            }
            return null; //No hay ningun deporte con esas caracteristicas
        }

        //esto lo puse de yapa para validar la edad de los socios, dato de color, podemos borrarlo, es para validar la categoria, para mi es mas prolijo
        private bool ValidarEdadPorCategoria(int edad, string categoria)
        {
            // Dependiendo de la categoría, se valida si la edad es correcta
            if (categoria == "Infantil") return edad <= 12;
            if (categoria == "Cadete") return edad >= 13 && edad <= 15;
            if (categoria == "Juvenil") return edad >= 16 && edad <= 18;
            if (categoria == "Mayor") return edad > 18;
            return false; // Si la categoría no es válida para la edad
        }

        //Inscribir un socio en un deporte si es que existe ese deporte y categoria
        public string InscribirSocio(Socio s)
        {
            if (!ValidarEdadPorCategoria(s.Edad, s.Categoria)) //Este if sirve para verificar si existe la categoria de su edad
                return "Edad invalida para la categoria.";

            Deporte d = BuscarDeporte(s.Deporte, s.Categoria); //Buscamos el deporte en la categoría
            if (d == null) // Si no existe retornamos falso
                return "No existe el deporte en esa categoria.";

            if (!d.Inscribir(s))
                return "El socio ya estaba inscripto.";


            


                return "OK"; // Si existe inscribimos al socio a ese deporte y categoria, fijate que estamos usando el metodo inscribir de la clase deporte
        }

        //Dar de baja a un socio por su DNI en un deporte
        public bool DarDeBajaSocio(string dni, string deporte, string categoria)
        {
            Deporte d = BuscarDeporte(deporte, categoria); //Buscamos el deporte
            if (d == null) //Si no existe el deporte, no se puede dar de baja
                return false;

            return d.DarDeBaja(dni); //Si existe, lo damos de baja, fijate que aca tambien, estamos usando un metodo de la clase deporte
        }

        public bool RegistrarPago(string dni, string deporte, string categoria, int mes)
        {
            
            Deporte d = BuscarDeporte(deporte, categoria); //Buscamos el deporte
            
            if (d == null) //Si no existe el deporte, no se hace el pago
            {
                return false;
            }

            for (int i = 0; i < d.Inscriptos.Count; i++) //Recorremos los socios inscriptos en el deporte
            {
                if (d.Inscriptos[i].Dni == dni) //Comprobamos si algun socio tiene ese DNI
                {
                    //Comprobamos si el mes de pago es distinto al ultimo mes pago
                    if (mes > d.Inscriptos[i].UltimoMesPago || (mes == 1 && d.Inscriptos[i].UltimoMesPago == 12))
                    {
                        

                        d.Inscriptos[i].UltimoMesPago = mes; //Actualizamos el último mes de pago


                        return true;
                    }

                    return false; //Si el mes es igual o antes, no se genera el pago
                }
            }

            return false; //Si no se encuentra el socio retornamos false tambien
        }

        


        //listar los socios que tienen deudas con la cuota
        public List<Socio> ListarDeudores(int mesActual)
        {
            List<Socio> deudores = new List<Socio>(); // Lista para almacenar a los que no pagaron
            for (int i = 0; i < deportes.Count; i++) //Recorremos todos los deportes
            {
                List<Socio> lista = deportes[i].Inscriptos; //Creamos una lista para tener los inscriptos en ese deporte
                for (int j = 0; j < lista.Count; j++) //recorremos los socios
                {
                    if (lista[j].UltimoMesPago < mesActual || (lista[j].UltimoMesPago == 12 && mesActual == 1)) //Si el último mes de pago es menor al mes actual o si el último mes fue diciembre y el mes actual es enero
                    {
                        deudores.Add(lista[j]); //Lo agregamos a la lista de deudores
                    }
                }
            }
            return deudores; //Devolvemos toda la lista de deudores
        }
        public void ImprimirEntrenadores()
        {
            foreach (var entrenador in entrenadores)
            {
                Console.WriteLine(entrenador);
            }
        }
        public void ImprimirInscriptos()
        {
            foreach(var inscriptos in socio)
            {
                Console.WriteLine(socio);
            }
        }
        public double CalcularCuota(double cuotaBase)
        {
            
            //Calculamos la cuota restando el porcentaje de descuento, si es que tiene
            return cuotaBase - (cuotaBase * descuento / 100);
        }

        public void ListadoPorDeporte()
        {
           foreach(var deporte in deportes)
            {
                Console.WriteLine($"Deporte: {deporte.Nombre} {deporte.Categoria}");
                var inscriptos=deporte.Inscriptos;
                if(inscriptos.Count == 0)
                {
                    Console.WriteLine(" No hay inscriptos.");
                }
                else
                {
                    foreach(var socio in inscriptos)
                    {
                        Console.WriteLine($" - {socio.Nombre} (DNI: {socio.Dni})");
                    }
                }
                Console.WriteLine();
            }
        }
        public void ListadoInscriptosPorDeporteYCategoria()
        {
            foreach (var deporte in deportes) // Recorremos tal cual están cargados
            {
                Console.WriteLine($"Deporte: {deporte.Nombre} | Categoría: {deporte.Categoria}");

                var inscriptos = deporte.ObtenerInscriptos();

                if (inscriptos.Count == 0)
                {
                    Console.WriteLine("  No hay inscriptos.");
                }
                else
                {
                    foreach (var socio in inscriptos)
                    {
                        Console.WriteLine($"  - {socio.Nombre} (DNI: {socio.Dni})");
                    }
                }

                Console.WriteLine(); // Línea en blanco entre deportes
            }
        }


    }
}
