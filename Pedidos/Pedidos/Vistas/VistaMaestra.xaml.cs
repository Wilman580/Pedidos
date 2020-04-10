using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pedidos.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VistaMaestra : MasterDetailPage
	{
		public VistaMaestra ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            App.Maestra = this;
            App.Navigator = this.Navigator;
        }
    }
}