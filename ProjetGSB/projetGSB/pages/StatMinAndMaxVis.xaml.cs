using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projetGSB.pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StatMinAndMaxVis : ContentPage
	{
		public StatMinAndMaxVis ()
		{
			InitializeComponent ();
            StatMinAndMaxVisiteurs();
		}

        private async void BtnRetour_ClickedAsync(object sender, EventArgs e)
        {
            StatistiqueRegion page = new StatistiqueRegion();
            await Navigation.PushModalAsync(page);
        }

        private async void StatMinAndMaxVisiteurs()
        {
            lvMinAndMaxVis.ItemsSource = await App.GstWS.GetRegMinAndMaxVisiteurAsync();
        }

    }
}