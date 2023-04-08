using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto12
{
    internal class Persona
    {
        public string Name { get; set; }
        public int Edad { get; set; }

        public Persona(string name, int edad)
        {
            Name = name;
            Edad = edad;
        }

        // Algunos métodos de la clase Object
        // Método Equals: Siempre necesita 2 comprobaciones
        public override bool Equals(object? obj)
        {
            // 1- Objeto != de Nulo
            if (obj == null) { return false; }
            
            // 2- Objeto pertenece a esta clase
            Persona p = obj as Persona;
            if(p == null) { return false; }

            return(Name == p.Name) && (Edad == p.Edad);
        }

        // Método GetHashCode: al sobreescribir Equals, se debe sobreescribir GetHashCode también
        public override int GetHashCode()
        {
            // Receta:
            // 1- hash == nro primo
            int hash = 17;
            // 2- hash = (hash * primo) + At.GetHashCode();
            hash = (hash * 7) + Name.GetHashCode();
            hash = (hash * 7) + Edad.GetHashCode();

            return hash;
        }
    }
}
