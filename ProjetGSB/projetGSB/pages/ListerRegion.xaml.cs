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
	public partial class ListerRegion : ContentPage
	{
		public ListerRegion ()
		{
			InitializeComponent ();
            lstRegion();

        }

        private async void BtnRetour_ClickedAsync(object sender, EventArgs e)
        {
            AccueilRegion page = new AccueilRegion();
            await Navigation.PushModalAsync(page);
        }
        public async void lstRegion()
        {
            lvToutesLesRegions.ItemsSource = await App.GstWS.GetAllRegionsAsync();
        }

        private async void BtnStat_ClickedAsync(object sender, EventArgs e)
        {
            StatistiqueRegion page = new StatistiqueRegion();
            await Navigation.PushModalAsync(page);         
        }
    }
}