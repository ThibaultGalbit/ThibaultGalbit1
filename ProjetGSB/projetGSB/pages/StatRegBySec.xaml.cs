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
	public partial class StatRegBySec : ContentPage
	{
		public StatRegBySec ()
		{
			InitializeComponent ();
            nbRegionBySecteurs();

        }

        private async void BtnRetour_ClickedAsync(object sender, EventArgs e)
        {
            StatistiqueRegion page = new StatistiqueRegion();
            await Navigation.PushModalAsync(page);
        }

        public async void nbRegionBySecteurs()
        {
            lvStatRegBySec.ItemsSource = await App.GstWS.GetNbRegionBySecteurAsync();
        }

    }
}