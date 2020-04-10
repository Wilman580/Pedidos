using GalaSoft.MvvmLight.Command;
using Pedidos.Servicios;
using Pedidos.Vistas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Pedidos.ModelosVista
{
    public class ModeloVistaPrincipal
    {
        ServicioNavegar servicioNavegar;
        #region Propiedades
        public ObservableCollection<ModeloVistaArticuloMenu> Menu { get; set; }
        public ObservableCollection<ModeloVistaOrdenes> Ordenes { get; set; } 
        #endregion

        #region Constructor
        public ModeloVistaPrincipal()
        {
            servicioNavegar = new ServicioNavegar();
            CargarMenu();
            CargarDatos();
        }
        #endregion

        #region Comandos
        public ICommand GoToCommand
        {
            get { return new RelayCommand<string>(GoTo); }
        }

        private void GoTo(string nombreVista)
        {
            servicioNavegar.Navegar(nombreVista);
        }

        public ICommand ComandoEmpezar
        {
            get { return new RelayCommand(Empezar); }
        }

        private void Empezar()
        {
            servicioNavegar.NuevaVistaPrincipal("maestra");
        }
        #endregion

        #region Metodos
        private void CargarMenu()
        {
            Menu = new ObservableCollection<ModeloVistaArticuloMenu>();
            Menu.Add(new ModeloVistaArticuloMenu()
            {
                Icono = "ic_menu_item",
                Titulo = "Pedidos",
                NombreVista = "VistaPrincipal"
            });
            Menu.Add(new ModeloVistaArticuloMenu()
            {
                Icono = "ic_menu_item",
                Titulo = "Clientes",
                NombreVista = "VistaClientes"
            });
            Menu.Add(new ModeloVistaArticuloMenu()
            {
                Icono = "ic_menu_item",
                Titulo = "Alarmas",
                NombreVista = "VistaAlarmas"
            });
            Menu.Add(new ModeloVistaArticuloMenu()
            {
                Icono = "ic_menu_item",
                Titulo = "Configuracion",
                NombreVista = "VistaConfiguracion"
            });
        }
        private void CargarDatos()
        {
            Ordenes = new ObservableCollection<ModeloVistaOrdenes>();
            for (int i = 0; i < 5; i++)
            {
                Ordenes.Add(new ModeloVistaOrdenes()
                {
                    Titulo = "Titulo pedido",
                    FechaEntrega = DateTime.Today,
                    Descripcion = "Texto requerido acerca del pedido"
                });
            }
        } 
        #endregion
    }
}
