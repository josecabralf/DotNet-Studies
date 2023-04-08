namespace Proyecto17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipo de Valor
            // No podemos referirnos de 2 lugares a un mismo dato (se genera una copia del dato)
            PuntoVal puntoV1 = new PuntoVal(5, 10);
            PuntoVal puntoV2 = puntoV1;

            puntoV2.X = 3;
            puntoV2.Y = 4;

            Console.WriteLine("pto: ({0}, {1})", puntoV1.X, puntoV1.Y);
            Console.WriteLine("pto: ({0}, {1})", puntoV2.X, puntoV2.Y);

            Console.WriteLine();

            // Tipo de Referencia
            PuntoRef puntoR1 = new PuntoRef(5, 10);
            PuntoRef puntoR2 = puntoR1;

            // R1 y R2 refieren al mismo espacio de memoria
            // .: Alterar uno altera al otro
            puntoR2.X = 3;
            puntoR2.Y = 4;

            Console.WriteLine("pto: ({0}, {1})", puntoR1.X, puntoR1.Y);
            Console.WriteLine("pto: ({0}, {1})", puntoR2.X, puntoR2.Y);
        }
    }
}