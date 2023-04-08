using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto14
{
    // Para ordenar objetos se debe aplicar el método de una interfaz: IComparable
    // IComparable: permite la comparación de objetos de una misma clase
    internal class Producto : IComparable<Producto>
    {
        public string Codigo { get; set; }
        public decimal Precio { get; set; }

        // El método CompareTo puede regresar 3 valores
        public int CompareTo(Producto otro)
        {
            // 1 : es mayor
            if(this.Precio > otro.Precio) return 1;
            // 0: es igual
            if (this.Precio == otro.Precio) return 0;
            // -1 : es menor
            return -1;
        }

    }
}
