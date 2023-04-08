using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto5
{
    internal class Persona
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private int _edad;
        public int Edad
        {
            get { return _edad; }
            set { _edad = value >= 0 ? value : 0; }
        }
        #endregion

        #region Constructores
        public Persona(string nom)
        {
            Nombre = nom;
        }
        public Persona(string nom, string ape) : this(nom)
        {
            Apellido = ape;
        }
        public Persona(string nombre, string apellido, int edad) : this(nombre, apellido)
        {
            Edad = edad;
        }
        public Persona() {}
        #endregion

        #region Metodos
        public void Saludar()
        {
            Console.WriteLine("Hola {0} {1}", Nombre, Apellido);
        }

        public override string ToString()
        {
            return String.Format("Nombre Completo: {0} {1}, Edad: {2}", 
                Nombre, Apellido, Edad);
        }
        #endregion
    }
}
