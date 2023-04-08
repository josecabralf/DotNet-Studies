namespace Proyecto16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complejo c1 = new Complejo(3, 4);
            Complejo c2 = new Complejo(-0.5, 2);

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Complejo res = c1.Suma(c2);
            Console.WriteLine("Suma: {0}", res);

            res = c1.Multiplica(c2);
            Console.WriteLine("Multiplicación: {0}", res);
        }
    }
}