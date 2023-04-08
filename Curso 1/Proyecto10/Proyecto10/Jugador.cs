namespace Proyecto10
{
    // POO: organizar, optimizar y reutilizar [DRY: Don't Repeat Yourself]
    // Clases: Sintaxis
    // class name {code}

    // Herencia: Clase Padre
    class Jugador
    {
        // Atributo: variable definida en una clase
        // Tipos de Atributos:
        // 1- public: accesibles para todas las clases
        // 2- private: accesibles para misma clase
        // 3- protected: accesibles para misma clase o clases que heredan
        // 4- internal: solo para los de mismo ensamble
        public string nom = "Jugador01";
        public int num = 1;

        public void Saludar()
        {
            Console.WriteLine("Hola!");
        }
    }

    // enum: es una clase especial que representa un grupo de valores incambiables
    enum JugadoresAnteriores
    {
        José,
        David,
        Benjamín,
        Emilia,
        Julieta,
        Roberto,
        Tomás,
        Nicolás,
        Santiago
    }

}