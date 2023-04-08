namespace Proyecto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("José", "Cabral", 19);
            Persona persona2 = new Persona("Juan", "Nieves", -5);

            persona1.Saludar();
            persona2.Saludar();

            Console.WriteLine(persona2.ToString());
        }
    }
}