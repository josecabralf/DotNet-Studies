namespace Proyecto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Programa: Tablas de Multiplicar");
            bool ciclo = true;

            while (ciclo)
            {
                Console.WriteLine();
                Console.Write("Ingrese el número deseado: ");
                string dato = Console.ReadLine();
                int num = int.Parse(dato);

                Console.WriteLine();

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} * {1} = {2}", num, i, num*i);
                }

                Console.WriteLine();

                Console.WriteLine("Desea Continuar: 1- Si   2-No");
                Console.Write("Decisión: ");
                dato = Console.ReadLine(); ;
                if (dato == "1")
                {
                    ciclo = true;
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Saludos! Fin.");
        }
    }
}