namespace Proyecto10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Carlos", 30);
            p.Saludar();

            Console.WriteLine();

            Empleado e = new Empleado("Pedro", 25, "Ventas", 10000);
            e.Saludar();
            e.Trabajar();

            Console.WriteLine();
            Console.WriteLine(p.ToString());
            Console.WriteLine(e.ToString());
        }
    }
}