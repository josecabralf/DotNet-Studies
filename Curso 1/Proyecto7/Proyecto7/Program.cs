namespace Proyecto7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ciclos: while, do while, for
            // Repiten una expresión mientras esta sea verdadera
            // While: realiza la acción solo sí el arg == True
            // Do While: realiza la acción una vez, y luego solo sí el arg == True
            // For: == Python

            // Controles de Loops:
            // break: termina el ciclo
            // continue: termina la iteración actual de ciclo


            // While:
            int x = 0;
            while (x != 5) 
            {
                x++;
                
                // Ejemplo de continue
                if (x == 3)
                {
                    Console.WriteLine("Continue en " + x);
                    continue;
                }

                Console.WriteLine("Ciclo While: x = " + x);
            }
            Console.WriteLine();

            // Do While:
            do
            {
                x++;
                Console.WriteLine("You did it! x = " + x);
            }
            while (x < 5);
            Console.WriteLine();

            // For:
            for (int i = 0; i <= 8; i = i + 2)
            {
                Console.WriteLine("Ciclo for: i = " + i);
            }
            Console.WriteLine();

            // Ciclos sobre arreglos:
            string[] frutas = { "Banana", "Manzana", "Ciruela", "Damasco", "Frutillas" };
            foreach (string frut in frutas)
            {
                // Ejemplo de break
                if (frut == "Damasco")
                {
                    Console.WriteLine("Break en " + frut);
                    break;
                }

                Console.WriteLine("For each fruta: " + frut);
            }
        }
    }
}