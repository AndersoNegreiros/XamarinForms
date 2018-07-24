using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_PaginaXF.TipoPagina.Carrossel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
		}

        private void MudarPagina ( object sender, EventArgs args)
        {
            // Força transição entre páginas do carrocel para a contentPage
            //App.Current.MainPage = new NavigationPage(new Navigation.Pagina1()) {BarBackgroundColor = Color.Blue}; // instanciando inicialmente para depois poder usar o NavigationPage

            App.Current.MainPage = new Tabbed.Abas();
        }

    }
}