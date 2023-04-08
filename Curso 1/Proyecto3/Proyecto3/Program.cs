namespace Proyecto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine(): Permite input de user.
            //Siempre devuelve String
            Console.Write("Ingrese su Nombre: ");
            string nom = Console.ReadLine();

            Console.Write("Ingrese su Apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Nombre Completo: " + nom + " " + apellido);

            Console.Write("Ingrese su DNI: ");
            int dni = Convert.ToInt32(Console.ReadLine());
            int dni2 = dni + 1;
            Console.WriteLine("Su DNI NO es " + dni2);
            Console.WriteLine();

            //Operadores Aritméticos:
            // Suma (+), Resta (-), Multiplicación (*), División (/)
            // Módulo (%), Increment (x++), Decrement (x--)
            // [x es una variable]

            Console.WriteLine("Operadores Aritméticos:");

            int val1 = 20;
            int val2 = 10;

            Console.WriteLine("Valores Usados: val1 = " + val1 + " val2 = " + val2);

            Console.Write("Suma: ");
            Console.WriteLine(val1 + val2);

            Console.Write("Resta: ");
            Console.WriteLine(val1 - val2);

            Console.Write("Multiplicación: ");
            Console.WriteLine(val1 * val2);

            Console.Write("División: ");
            Console.WriteLine(val1 / val2);

            Console.Write("Módulo: ");
            Console.WriteLine(val1 % val2);

            //Notar que si el Incremento/Decremento se escribe después
            //Dentro del print, no será mostrado realizado hasta después
            //De mostrarlo en pantalla. Para eso: ++var/--var en print
            Console.Write("Incrementar: ");
            val1++;
            Console.WriteLine(val1++);
            Console.Write("Decrementar: ");
            val2--;
            Console.WriteLine(--val2);

            //Operadores de Asignación:
            // =, +=, -=, *=, /=, %=, &=
            Console.WriteLine();
            Console.WriteLine("Operadores de Asignación:");

            int valor = 10;
            Console.WriteLine("int valor = 10: " + valor);

            valor += 10;
            Console.WriteLine("valor += 10: " + valor);

            valor *= 10;
            Console.WriteLine("valor *= 10: " + valor);

            //Operadores de Comparación: [Output = Booleano]
            // ==, !=, >, >=, <, <=
            Console.WriteLine();
            Console.WriteLine("Operadores de Comparación:");

            Console.Write("val1 == val2: ");
            Console.WriteLine(val1 == val2);
            Console.Write("val1 > val2: ");
            Console.WriteLine(val1 > val2);

            //Operadores Lógicos:
            // And: &&, Or: ||, Not: !
            Console.WriteLine();
            Console.WriteLine("Operadores de Lógicos:");

            Console.Write("val1 > 7 && val2 > 7: ");
            Console.WriteLine(val1 > 7 && val2 > 7);
            Console.Write("!(val1 > 7 && val2 > 7): ");
            Console.WriteLine(!(val1 > 7 && val2 > 7));
        }
    }
}