using projetGSB.classeMetier;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace projetGSB
{
    public partial class App : Application
    {
        public static string localhost { get; set; }
        public static List<classeMetier.Region> lstregions{get;set;}
        public static List<StatRegion> statRegions { get; set; }
        public static GstWebServices GstWS { get; set;}
        public App()
        {
            InitializeComponent();
            //localhost = "http://localhost/WSGSBOCK/";
            localhost = "http://thibaut.sio19ingetis.lan/ProjetGSB/WSGSBOCK/";
            MainPage = new MainPage();
            GstWS = new GstWebServices();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
