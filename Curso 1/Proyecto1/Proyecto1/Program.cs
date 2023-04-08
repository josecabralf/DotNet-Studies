namespace Proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // print == Console.Writeline("...")

            /* Para hacer comentarios
             * de más de una linea*/

            //Display Output: Write vs WriteLine
            // Write: hace un print sin \n
            //WriteLine: hace un print y ocupa toda la linea

            Console.Write("Aloha!");
            Console.WriteLine(":)");
            //Output == Aloha!:)

            /* Efectos de Output:
             * \t: Agrega un tab
             * \n: New Line (enter)
             * \b: Backspace
             */

            // Console.ReadKey: evita que el programa termine
            // hasta apretar una tecla.
            Console.ReadKey();
        }
    }
}