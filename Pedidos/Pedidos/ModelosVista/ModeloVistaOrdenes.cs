using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos.ModelosVista
{
    public class ModeloVistaOrdenes
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreada { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string InformacionEntrega { get; set; }
        public string Cliente { get; set; }
    }
}
