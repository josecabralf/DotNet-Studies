using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class ControlAgenda
    {
        private Agenda _agenda;

        public ControlAgenda(Agenda agenda)
        {
            _agenda = agenda;
        }

        // Limpiar Consola
        private static void Limpiar()
        {
            Console.Clear();
        }
        // Mostrar Opciones
        public void MostrarMenu()
        {
            string menu = String.Format(
                "Agenda de Contactos\n" +
                "1. Mostrar Orden Ascendente\n" +
                "2. Mostrar Orden Descendente\n" +
                "3. Salir\n" +
                "Seleccione Opción: ");

            Console.WriteLine(menu);
        }
        // Pausas
        private static void Presiona()
        {
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
        public void VerContactos()
        {
            Limpiar();
            MostrarMenu();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Limpiar();
                    Console.WriteLine("Contactos en Orden Ascendente:");
                    _agenda.MostrarAsc();
                    break;
                case "2":
                    Limpiar();
                    Console.WriteLine("Contactos en Orden Descendente:");
                    _agenda.MostrarAsc();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opción No Valida!");
                    break;
            }

            Presiona();
        }

        public void AgregarContacto()
        {
            Limpiar();
            Console.WriteLine("Nuevo Contacto");
            Contacto c = new Contacto();

            Console.Write("Nombre: ");
            c.Nombre = Console.ReadLine();
            Console.Write("Teléfono: ");
            c.Telefono = Console.ReadLine();
            Console.Write("Email: ");
            c.Email = Console.ReadLine();

            _agenda.AgregarContacto(c);
            Console.WriteLine("Contacto Agregado");
            Presiona();
        }

        public void BorrarContacto()
        {
            Limpiar();
            _agenda.BorrarUltContacto();
            Console.WriteLine("Contacto Borrado");
            Presiona();
        }

        public void BuscarPorNombre()
        {
            Limpiar();
            Console.WriteLine("Buscar Contacto");
            Console.Write("Nombre: ");
            string nom = Console.ReadLine();

            Contacto c = _agenda.BuscarPorNom(nom);

            if (c != null) { Console.WriteLine("Datos:\n" + c); }
            else { Console.WriteLine("Contacto no encontrado"); }
            Presiona();
        }
    }
}
