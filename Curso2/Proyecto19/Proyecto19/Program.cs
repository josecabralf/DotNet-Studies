using System;

namespace Proyecto19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Manejo de Errores: Excepciones
            bool pr = true;
            do
            {
                try
                {
                    Console.Write("Ingresa numerador: ");
                    int num = int.Parse(Console.ReadLine());

                    Console.Write("Ingresa denominador: ");
                    int den = int.Parse(Console.ReadLine());

                    int res = num / den;
                    Console.WriteLine("Resultado: {0}", res);
                    pr = false;
                }
                // Por cada excepcion a agarrar, se agrega un bloque catch
                catch (FormatException formatException)
                {
                    // Format Exception: son de formato. Ej. Ingresar un char cuando se pide int
                    Console.WriteLine("\n" + formatException.Message);
                    Console.WriteLine("Debes ingresar 2 enteros");
                }
                catch (DivideByZeroException format)
                {
                    Console.WriteLine("\n" + format.Message);
                    Console.WriteLine("No se puede dividir por 0");
                }
                // Para cuando hay muchas opciones de error: Exception [clase más genérica]
                catch(Exception e)
                {
                    Console.WriteLine("Algo salió mal...Vuelve a intentar!");
                }
            }
            while (pr);
            
            Console.WriteLine("Fin!");
        }
    }
}