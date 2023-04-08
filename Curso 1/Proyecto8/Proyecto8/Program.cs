namespace Proyecto8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arreglos: Sintaxis
            // type[] nom = {val1, val2, val3,..., valn};
            int[] angulos = { 135, 90, 60, 0, 45 };

            // Para especificar el número de espacios en un arreglo
            // Sirve principalmente para crear arreglos vacíos
            string[] nomAng = new string[4] { "nulo", "agudo", "recto", "obtuso" };

            // Acceso a datos: índices [0, n-1]
            foreach (int angulo in angulos)
            {
                if (angulo == 0)
                {
                    Console.WriteLine("El ángulo " + angulo + " es " + nomAng[0]);
                }
                else if (0 < angulo && angulo < 90)
                {
                    Console.WriteLine("El ángulo " + angulo + " es " + nomAng[1]);
                }
                else if(angulo == 90)
                {
                    Console.WriteLine("El ángulo " + angulo + " es " + nomAng[2]);
                }
                else
                {
                    Console.WriteLine("El ángulo " + angulo + " es " + nomAng[3]);
                }
            }

            // Cambiar valores: se utiliza el índice:
            angulos[2] = 75;
            string res = (0 < angulos[2] && angulos[2] < 90) ? string.Concat("El ángulo ", angulos[2], " es ", nomAng[1]) : string.Concat("El ángulo ", angulos[2], " no es ", nomAng[1]);
            Console.WriteLine(res);
            Console.WriteLine();

            // Conseguir el largo de un arreglo: nom.Length
            for (int i = 0; i < angulos.Length; i++)
            {
                Console.WriteLine("El ángulo " + (i+1) + " es " + angulos[i]);
            }
            Console.WriteLine();

            // Ordenar arreglos: método sort
            // Sintaxis: Array.sort(nom); [Orden ascendente]
            Array.Sort(angulos);
            for (int i = 0; i < angulos.Length; i++)
            {
                Console.WriteLine("El ángulo " + (i+1) + " es " + angulos[i]);
            }
        }
    }
}