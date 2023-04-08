namespace ProyectoFinal
{
    internal class Program
    {
        static ControlAgenda control = new ControlAgenda(new Agenda());
        
        static void Main(string[] args)
        {
            string opcion = "";

            do
            {
                Console.Clear();
                Console.WriteLine("Agenda de Contactos");
                Menu();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        control.VerContactos();
                        break;
                    case "2":
                        control.AgregarContacto();
                        break;
                    case "3":
                        control.BorrarContacto();
                        break;
                    case "4":
                        control.BuscarPorNombre();
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                } 
            } while (opcion!="5");
        }

        static void Menu()
        {
            string menu = String.Format("Agenda de Contactos\n" + 
                "1. Ver Contactos\n" +
                "2. Agregar Contactos\n" +
                "3. Borrar Último Contacto\n" +
                "4. Buscar Contacto por Nombre\n" +
                "5. Salir\n" +
                "Seleccione una Opcion: ");

            Console.Write(menu);
        }
    }
}