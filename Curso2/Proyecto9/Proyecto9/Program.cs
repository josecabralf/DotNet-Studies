namespace Proyecto9
{
    internal class Program
    {
        static void PrintMatrixInt(int[,] mat)
        {
            // Recorrer arreglo: 1 ciclo for x dimensión

            // Filas: GetLength(0)
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                // Columnas: GetLength(1)
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("{0} ", mat[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void PrintMatrixDob(double[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    // Formato para == cantidad de decimales
                    Console.Write("{0:0.#0} ", mat[i, j]);
                }
                Console.WriteLine();
            }
        }

        // ToDouble Matriz
        static double[,] MatToDob(int[,] mat)
        {
            double[,] newmat = new double[mat.GetLength(0), mat.GetLength(1)];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    newmat[i,j] = Convert.ToDouble(mat[i,j]);
                }
            }
            return newmat;
        }

        // Suma de Matrices
        static double[,] SumaMat(double[,] mat1, double[,] mat2)
        {
            if(mat1.GetLength(0) == mat2.GetLength(0) && mat1.GetLength(1) == mat2.GetLength(1)) 
            {
                double[,] suma = new double[mat1.GetLength(0), mat1.GetLength(1)];
                for (int i = 0; i < mat1.GetLength(0); i++)
                {
                    for (int j = 0; j < mat1.GetLength(1); j++)
                    {
                        suma[i, j] = mat1[i, j] + mat2[i, j];
                    }
                }
                return suma;
            }
            else
            {
                Console.WriteLine("Error: Matrices de Distinto Orden!");
                return null;
            }
        }

        static void Main(string[] args)
        {
            // Arreglos Multidimensionales:
            int[,] a = new int[2, 2] { {0, 0}, {1, 2} };
            // Por cada ',' se agrega una dimensión al arreglo
            // int[3,2] refiere a cual será la dist de filas y columnas: 3x2
            Console.WriteLine("Matriz A");
            PrintMatrixInt(a);

            double[,] b = new double[2, 2] { { 0.5, 1.23 }, { 2.55, 4 } };
            Console.WriteLine("\nMatriz B");
            PrintMatrixDob(b);

            double[,] a2 = MatToDob(a);

            double[,] suma = SumaMat(a2, b);

            Console.WriteLine("\nSuma:");
            PrintMatrixDob(suma);
        }
    }
}