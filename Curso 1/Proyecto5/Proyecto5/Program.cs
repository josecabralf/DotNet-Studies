namespace Proyecto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Strings
            string hello = "Hello ";
            Console.WriteLine(hello);
            string world = "World!";
            Console.WriteLine(world);

            //len(): var.length
            Console.WriteLine("World! length: " + world.Length);

            //Formas de concatenar: +, $, string.concat
            string helloWorld = string.Concat(hello, world);
            Console.WriteLine("Concat: " + helloWorld);

            //String interpolation:
            string helloWorld2 = $"El texto completo  con $ es: {hello} {world}";
            Console.WriteLine(helloWorld2);

            //Index numbers: arrancan de 0 [var(n)]
            Console.WriteLine("Índice 0 Hello: " + hello[0]);

            //Método IndexOf: nos indica la posición de cualquier character en el string
            // En caso de que el caracter no pertenezca al string, devuelve -1
            //Otros: LastIndexOf
            Console.WriteLine("Índice de l en hello: " + hello.IndexOf("l"));
            Console.WriteLine("Índice de última l en hello: " + hello.LastIndexOf("l"));

            //EndsWith("x"): booleano, especifica si string termina o no con xs

            //Escape characters:
            // 1- \': para escribir comillas simples dentro de un string
            // 2- \": para escribir comillas dobles dentro de un string
            // 3- \\: para escribir '\' dentro de un string
            // 4- \n: para hacer newLine
            // 5- \t: para agregar un tab
            // 6- \b: para agregar borrar caracteres

            //Ej:
            Console.WriteLine("\"" + helloWorld + "\"");
            Console.Write("\\" + helloWorld + "\\ \t");
            Console.Write(helloWorld + "\n");
            Console.WriteLine(world + "\b\b\b\n");

            //Conversiones a minúscula o mayúscula: var.ToLower, var.ToUpper
            Console.WriteLine();
            Console.WriteLine(helloWorld.ToUpper());
            Console.WriteLine(helloWorld.ToLower());
        }
    }
}