namespace Proyecto9
{
    internal class Program
    {
        // Creación de Métodos (Funciones): Sintaxis
        // static void MethodName(parameters) {code}
        // static: implica que forma parte de la clase programa y no a un objeto
        // void: implica que no devuelve ningun valor

        // Tipos de métodos:
        // 1- Predefinidos
        // 2- Definidos por usuarios

        // Metodos con parámetros:
        // Valores default: type parametro = val
        static void Saludar(string name = "Marquitos")
        {

            Console.WriteLine($"Hola {name}! Tu nariz contra mis bolas!");
        }

        static void RepetirSaludo(int n = 1, string name = "Marquitos")
        {
            for(int i = 0; i < n; i++)
            {
                Saludar(name);
            }
        }

        // Metodos con return
        static double Promedio(int[] array)
        {
            double suma = 0;
            int n = array.Length;

            foreach (int num in array)
            {
                suma += num;
            }

            return suma / n;
        }

        static void Main(string[] args)
        {
            // Saludar - Repetir
            Console.Write("Ingrese su nombre: ");
            string name = Console.ReadLine();
            Console.Write("Ingrese un nro de Saludos: ");
            int n = Convert.ToInt32(Console.ReadLine());
            RepetirSaludo(n, name);

            Console.WriteLine();
            Saludar();

            Console.WriteLine();

            // Promedio
            Console.Write("Ingrese nro de elementos a promediar: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[x];
            
            for (int i = 0; i < x; i++)
            {
                Console.Write("Ingrese el nro " + (i+1) + ": ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            double prom = Promedio(array);
            prom = Math.Round(prom, 2);

            Console.WriteLine("El promedio fue de: " + prom);
        }

    }
}