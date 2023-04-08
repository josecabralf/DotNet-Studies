namespace Proyecto11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpleadoHonorarios eh = new EmpleadoHonorarios("John", "Marketing", 12000);
            eh.Trabajar();
            Console.WriteLine("Salario por Honorarios de {0}: {1}", eh.Nombre, eh.Salario);

            EmpleadoNomina en = new EmpleadoNomina("Mark", "Ventas", 15000);
            en.Trabajar();
            Console.WriteLine("Salario por Nomina de {0}: {1}", en.Nombre, en.Salario);
        }
    }
}