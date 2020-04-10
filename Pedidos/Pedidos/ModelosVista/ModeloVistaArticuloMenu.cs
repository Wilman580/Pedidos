using GalaSoft.MvvmLight.Command;
using Pedidos.Servicios;
using Pedidos.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Pedidos.ModelosVista
{
    public class ModeloVistaArticuloMenu
    {
        ServicioNavegar servicioNavegar;
        public string Icono { get; set; }
        public string Titulo { get; set; }
        public string NombreVista { get; set; }
        public ModeloVistaArticuloMenu()
        {
            servicioNavegar = new ServicioNavegar();
        }

        public ICommand ComandoNavegacion
        {
            get { return new RelayCommand(()=>servicioNavegar.Navegar(NombreVista)); }
        }

        
    }
}
