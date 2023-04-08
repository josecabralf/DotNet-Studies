using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto10
{
    // Abstracción: Ocultar detalles de implementación y mostrar solo lo esencial
    // Clases abstractas: estan restringidas. No pueden crear objetos, solo pueden ser heredadas.
    // Métodos abstractos: solo pueden usarse en clases abstractas. No tienen cuerpo

    // Interfaz: se utiliza para lograr abstracción
    // Significado: es una clase abstracta que solo contiene métodos y propiedades abstractas
    interface IDPlayer
    {
        void llamarJugador(); //No tiene cuerpo
    }

    // Herencia: Clase Hija
    class JG01 : Jugador, IDPlayer
    {
        public int id = 1100;

        // Aquí se crea el cuerpo del método de la interfaz
        public void llamarJugador()
        {
            Console.WriteLine("Estás listo Jugador?");
        }
    }


}
