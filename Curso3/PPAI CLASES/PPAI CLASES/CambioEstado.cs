using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    internal class CambioEstado
    {
        #region Properties
        public DateTime FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public Estado nuevoEstado { get; set; }
        #endregion

        #region Constructor
        public CambioEstado(DateTime inicio, Estado estado) 
        {
            FechaHoraInicio = inicio;
            FechaHoraFin = null;
            nuevoEstado = estado;
        }
        #endregion

    }
}
