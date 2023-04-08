using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto20
{
    internal class Contacto: IComparable<Contacto>
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        #endregion

        #region Constructores
        public Contacto(string nombre, string telefono, string email)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
        }
        #endregion

        public int CompareTo(Contacto otro)
        {
            if (otro == null) return 1;

            return Nombre.CompareTo(otro.Nombre);

        }

        public override string ToString()
        {
            return String.Format("Nombre: {0}\n Telefono: {1}\n Email: {2}", Nombre, Telefono, Email);
        }
    }
}
