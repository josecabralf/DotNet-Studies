namespace Proyecto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Programa: Calcular Área\n");

            // Crear Objeto: Rectángulo
            Rectangulo rect = new Rectangulo();

            // Asignar Valores a Atributos
            Console.Write("Ingrese la Base del Rectángulo: ");
            rect.Base = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la Altura del Rectángulo: ");
            rect.Altura = int.Parse(Console.ReadLine());

            Console.Write("\nEl área es: {0}\n", rect.CalcularArea());

            // Rectángulo 2
            Console.Write("Ingrese la Base del Rectángulo 2: ");
            int bas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la Altura del Rectángulo: ");
            int alt = int.Parse(Console.ReadLine());

            // Sintaxis de Inicialización Rápida:
            Rectangulo rect2 = new Rectangulo {Base = bas, Altura = alt};
            Console.Write("\nEl área es: {0}\n", rect2.CalcularArea());
        }
    }
}