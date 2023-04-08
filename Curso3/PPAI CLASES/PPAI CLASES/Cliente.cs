using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    internal class Cliente
    {
        #region Properties
        public int Dni { get; set; }
        public TipoDocumento TipoDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CodigoPostal { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public int CantHijos { get; set; }
        #endregion

        #region Constructores
        public Cliente(int dni, TipoDocumento tipo, string nombre, string apellido, string codPostal, DateOnly fechaNac, string telefono, int cantHijos)
        {
            Dni = dni;
            TipoDoc = tipo;
            Nombre = nombre;
            Apellido = apellido;
            CodigoPostal = codPostal;
            FechaNacimiento = fechaNac;
            Telefono = telefono;
            CantHijos = cantHijos;
        }
        #endregion
    }
}
