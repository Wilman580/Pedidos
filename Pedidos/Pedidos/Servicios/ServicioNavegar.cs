using Pedidos.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pedidos.Servicios
{
    public class ServicioNavegar
    {
        public async void Navegar(string nombreVista)
        {
            App.Maestra.IsPresented = false;
            switch (nombreVista)
            {
                case "VistaAlarmas":
                    await App.Navigator.PushAsync(new VistaAlarmas());
                    //await Navegando(new VistaAlarmas());//Es para la navegacion con configuración adicionales  
                    break;
                case "VistaClientes":
                    await App.Navigator.PushAsync(new VistaClientes());
                    break;
                case "VistaConfiguracion":
                    await App.Navigator.PushAsync(new VistaConfiguracion());
                    break;
                case "VistaNuevaOrden":
                    await App.Navigator.PushAsync(new VistaNuevaOrden());
                    break;
                case "VistaPrincipal":
                    await App.Navigator.PopToRootAsync();
                    break;
            }
        }

        private static async Task Navegando<T>(T vista) where T : Page
        {
            NavigationPage.SetHasBackButton(vista, false);
            NavigationPage.SetBackButtonTitle(vista, "Atrás");//Solo para iOS
            await App.Navigator.PushAsync(vista);
        }

        internal void NuevaVistaPrincipal(string vistaMaestra)
        {
            if (vistaMaestra.Equals("maestra"))
            {
                App.Current.MainPage = new VistaMaestra();
            }
        }
    }
}
