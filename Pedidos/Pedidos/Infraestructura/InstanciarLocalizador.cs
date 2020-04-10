using Pedidos.ModelosVista;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos.Infraestructura
{
    public class InstanciarLocalizador
    {
        public ModeloVistaPrincipal LocalizadorPrincipal { get; set; }

        public InstanciarLocalizador()
        {
            LocalizadorPrincipal = new ModeloVistaPrincipal();
        }
    }
}
