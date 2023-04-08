using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    internal class Llamada
    {
        #region Properties
        public DateTime Duracion { get; set; }
        public Cliente ClienteLlamada { get; set; }
        public string? Observacion { get; set; }
        public bool TieneEscucha { get; set; }
        public DateTime Fecha { get; set; }
        public Encuesta? EncuestaLlamada { get; set; }
        public Categoria? CategoriaLlamada { get; set; }
        public CambioEstado EstadoActual { get; set; }
        #endregion

        #region Constructor
        Llamada(Cliente cl, DateTime duracion, DateTime fecha, CambioEstado estado) 
        {
            Duracion = duracion;
            ClienteLlamada = cl;
            Observacion = null;
            TieneEscucha = false;
            Fecha = fecha;
            EncuestaLlamada = null;
            CategoriaLlamada = null;
            EstadoActual = estado;
        }
        #endregion
    }
}
