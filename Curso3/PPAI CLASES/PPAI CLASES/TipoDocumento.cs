using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    internal class TipoDocumento
    {
        #region Properties
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        #endregion

        #region Constructor
        public TipoDocumento(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
        #endregion
    }
}
