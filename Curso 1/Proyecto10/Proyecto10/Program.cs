using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear Objetos
            JG01 j1 = new JG01();
            j1.nom = "José";

            j1.Saludar();
            Console.WriteLine("Nombre de Jugador: " + j1.nom);
            Console.WriteLine("Número de Jugador: " + j1.num);
            Console.WriteLine("ID de Jugador: " + j1.id);
            j1.llamarJugador();

            // Acceder enum:
            JugadoresAnteriores jgActualNom = JugadoresAnteriores.José;
            // También pueden accederse por índices:
            int jgActualNum = (int) JugadoresAnteriores.José;

            Console.WriteLine();
            Console.Write(jgActualNom);
            Console.WriteLine(" " + jgActualNum);
        }
    }

}
