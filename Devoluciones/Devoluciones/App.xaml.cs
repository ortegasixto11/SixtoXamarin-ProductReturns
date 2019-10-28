using Devoluciones.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Devoluciones
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
            //MainPage = new NavigationPage(new MenuPage());
            //MainPage = new NavigationPage(new CerradoCajasPage());
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
