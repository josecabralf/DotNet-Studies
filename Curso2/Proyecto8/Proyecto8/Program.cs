namespace Proyecto8
{
    internal class Program
    {
       static void MostrarArregloNum(int[] nums)
        {
            foreach(int num in nums)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }

        static void MostrarArregloChar(char[] chars)
        {
            foreach (char @char in chars)
            {
                Console.Write("{0} ", @char);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region Arreglo
            // Arreglos: tienen tam fijo

            // Sintaxis 1: Inicializar arreglo vacío
            int[] nums = new int[5];
            nums[0] = 25;
            nums[1] = 30;
            nums[2] = 11;
            nums[3] = 7;
            nums[4] = 27;
            Console.WriteLine("Arreglo nums:");
            MostrarArregloNum(nums);
            // Como arreglo == objeto, tenemos new | [5] = tam arreglo (0-4)

            // Sintaxis 2: Inicializar arreglo con valores
            // char[] vocales = new char[] {'a', 'e', 'i', 'o', 'u'};

            //Sintaxis 3: Acortar Sintaxis 2
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            int tam = vocales.Length;

            Console.WriteLine("\nTamaño arreglo vocales: {0}", tam);
            Console.WriteLine("Última vocal {0}", vocales[vocales.Length - 1]);
            #endregion

            #region Iterar arreglo
            // Sintaxis 1:
            /*for(int i = 0; i < tam; i++)
            {
                Console.WriteLine("Vocal {0}: {1}", i, vocales[i]);
            }*/

            // Sintaxis 2:
            foreach (char vocal in vocales)
            {
                Console.Write("{0} ", vocal);
            }

            // Recorrer en reversa:
            Console.WriteLine("\nRecorrer nums en reversa");
            for (int i = vocales.Length - 1; 0 <= i; i--)
            {
                Console.Write("{0} ", vocales[i]);
            }

            #endregion

            #region Clase Array
            // Copiar un arreglo
            char[] vocales2 = new char[vocales.Length];
            Array.Copy(vocales, vocales2, vocales.Length);

            // Invertir un Arreglo:
            Array.Reverse(vocales2);
            Console.WriteLine("\n\nArreglo reverso vocales2:");
            MostrarArregloChar(vocales2);

            // Ordenar un Arreglo:
            Array.Sort(nums);
            Console.WriteLine("\nArreglo nums ordenado: ");
            MostrarArregloNum(nums);

            // Busqueda binaria: 
            int pos = Array.BinarySearch(vocales, 'i');
            Console.WriteLine("\nPosición de i: {0}", pos);
            #endregion
        }
    }
}