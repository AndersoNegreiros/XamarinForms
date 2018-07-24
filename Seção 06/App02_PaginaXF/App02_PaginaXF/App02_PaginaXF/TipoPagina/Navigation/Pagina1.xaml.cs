using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_PaginaXF.TipoPagina.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina1 : ContentPage
	{
		public Pagina1 ()
		{
			InitializeComponent ();
		}

        private void MudarParaPagina2(object sender, EventArgs args)
        {
            //Chamando a página e criando um histórico do caminho feito até a nova página. 
            Navigation.PushAsync(new Pagina2());
        }

        private void ChamarModal(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal()); 
        }
        private void ChamarMaster(object sender, EventArgs args)
        {
            // Sempre chamar CarouselPage, MasterDetails, tabbedPage dessa forma.
            App.Current.MainPage = new Master.Master();
        }
    }
}