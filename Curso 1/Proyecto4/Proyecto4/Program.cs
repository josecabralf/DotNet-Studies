namespace Proyecto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Métodos Matemáticos:");
            //Métodos:

            float x = -1.1f;
            int y = 4;
            Console.WriteLine("X = " + x + "    y = " + y);
            
            //Math.Max(x, y): devuelve el valor más grande entre 2 valores
            Console.Write("Math.Max(x, y): ");
            Console.WriteLine(Math.Max(x, y));

            //Math.Min(x, y): devuelve el valor más chico entre 2 valores
            Console.Write("Math.Min(x, y): ");
            Console.WriteLine(Math.Min(x, y));

            //Math.Sqrt(x): devuelve la raíz cuadrada de un nro
            Console.Write("Math.Sqrt(y): ");
            Console.WriteLine(Math.Sqrt(y));

            //Math.Abs(x): devuelve el valor absoluto de un nro
            Console.Write("Math.Abs(x): ");
            Console.WriteLine(Math.Abs(x));

            //Math.Round(x): redondea el nro al valor int más cercano
            Console.Write("Math.Round(x): ");
            Console.WriteLine(Math.Round(x));

            //Math.Pow(x,y): devuelve la potencia y-esima de x
            Console.Write("Math.Pow(x,y): ");
            Console.WriteLine(Math.Pow(x, y));
        }
    }
}