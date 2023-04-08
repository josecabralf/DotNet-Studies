using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Contacto : IComparable<Contacto>
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        #endregion

        #region Constructores
        public Contacto() { }
        public Contacto(string nombre, string telefono, string email)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
        }
        #endregion

        #region Clase Object
        public override bool Equals(object? obj)
        {
            if(obj== null) { return false; }
            Contacto other = obj as Contacto;
            if (other == null) { return false; }

            return string.Equals(Nombre, other.Nombre) &&
                string.Equals(Telefono, other.Telefono);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashNombre = (Nombre!=null? Nombre.GetHashCode():0);
                int hashTelefono = (Telefono!=null? Telefono.GetHashCode():0);
                return (hashNombre * 397) ^ (hashTelefono);
            }
        }

        public override string ToString()
        {
            return String.Format("Nombre: {0}\nTelefono: {1}\nEmail {2}",
                Nombre, Telefono, Email);
        }
        #endregion

        #region IComparable
        public int CompareTo(Contacto? other)
        {
            return Nombre.CompareTo(other.Nombre);
        }
        #endregion
    }
}
