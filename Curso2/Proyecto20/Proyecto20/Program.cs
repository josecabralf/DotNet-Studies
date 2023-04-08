namespace Proyecto20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables Iniciales
            int opcion = -1;

            string menu = String.Format(
                "Agenda de Contactos\n" +
                "1. Ver Contactos\n" +
                "2. Agregar Contactos\n" +
                "3. Borrar Último Contacto\n" +
                "4. Buscar Contacto por Nombre\n" +
                "5. Salir\n" +
                "Ingrese la Opción Elegida: ");

            Contacto[] contactos = new Contacto[20];
            contactos[0] = new Contacto("Yo", "000", "email@gmail.com");
            int nroContactos = 1;
            #endregion

            while (opcion != 5)
            {
                #region Menu de Opciones
                bool val = false;
                while (!val && !(opcion > 5 && 1 > opcion))
                {
                    try
                    {
                        Console.Write(menu);
                        opcion = int.Parse(Console.ReadLine());
                        if (opcion > 5 || 1 > opcion)
                        {
                            Console.WriteLine("\nLa Opción Elegida No Es Correcta... Intente de Nuevo");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        val = true;
                        Console.Clear();
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("\n" + ex.Message);
                        Console.WriteLine("La Opción Elegida No Es Correcta... Intente de Nuevo");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                #endregion

                #region Opcion 1
                if (opcion == 1)
                {
                    val = false;
                    #region Menu Op1
                    do
                    {
                        try
                        {
                            Console.Write("Ver Contactos\n" +
                                "1. Orden Ascendente\n" +
                                "2. Orden Descendente\n" +
                                "3. Regresar\n" +
                                "Ingrese la Opción Elegida: ");

                            opcion = int.Parse(Console.ReadLine());
                            if (opcion > 3 || 1 > opcion)
                            {
                                Console.WriteLine("\nLa Opción Elegida No Es Correcta... Intente de Nuevo");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            val = true;
                            Console.Clear();
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("\n" + ex.Message);
                            Console.WriteLine("La Opción Elegida No Es Correcta... Intente de Nuevo");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    while (!val && !(opcion > 3 && 1 > opcion));
                    #endregion
                    if (opcion == 1) { }
                    if (opcion == 2) { }
                    if (opcion == 3) { continue; }
                }
                #endregion

                #region Opcion 2
                if (opcion == 2)
                {
                    if (contactos.Length == nroContactos)
                    {
                        Console.WriteLine("No hay espacio para agendar nuevos contactos");
                        Console.WriteLine("Elimine alguno con la opción 3");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    Console.WriteLine("Nuevo Contacto:");
                    string nom = "";
                    string tel = "";
                    string email = "";

                    val = false;
                    // Nombre: nom
                    while (!val)
                    {
                        Console.Write("Nombre: ");
                        nom = Console.ReadLine();

                        if (nom.Length == 0)
                        {
                            Console.WriteLine("El Contacto debe tener un nombre...");
                            continue;
                        }

                        val = true;
                    }

                    val = false;
                    // Telefono: tel
                    while (!val)
                    {
                        Console.Write("Teléfono: ");
                        tel = Console.ReadLine();

                        if (tel.Length == 0)
                        {
                            Console.WriteLine("El Contacto debe tener un teléfono...");
                            continue;
                        }
                        else { val = true; }
                    }

                    val = false;
                    // Email: email
                    while (!val)
                    {
                        Console.Write("Email: ");
                        email = Console.ReadLine();

                        if (email.Length == 0)
                        {
                            Console.WriteLine("El Contacto debe tener un email...");
                            continue;
                        }
                        else { val = true; }
                    }

                    contactos[nroContactos] = new Contacto(nom, tel, email);

                    Console.WriteLine("Contacto Registrado!");
                    nroContactos++;
                    Console.ReadKey();
                    Console.Clear();

                }
            }
            #endregion

            #region Opcion 3
            if (opcion == 3)
            {

            }
            #endregion

            #region Opcion 4
            #endregion

            Console.WriteLine("Nos Vemos!");

        }
    }
}    


