using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtroNamespace
{
    internal class OtraClase
    {
        // Modificadores de Acceso:
        
        // Public: puede ser visto por cualquier clase
        public void MetodoPublico()
        {
            Console.WriteLine("Llamar Método Público");
        }

        // Protected:puede ser visto desde esta clase u otra que herede esta clase
        protected void MetodoProtected()
        {
            Console.WriteLine("Llamar Método Protegido");
        }

        // Internal: puede ser visto por cualquier clase dentro del mismo assembly
        // Assembly: conj de clases y namespaces guardados juntos
        // Por default todo lo perteneciente al proyecto esta en el mismo assembly
        internal void MetodoInternal()
        {
            Console.WriteLine("Llamar Método Interno");
        }

        // Private: puede ser visto solo por esta clase
        private void MetodoPrivado()
        {
            Console.WriteLine("Llamar Método Privado");
        }
    }
}
