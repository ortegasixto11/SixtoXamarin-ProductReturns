using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Devoluciones.Views;

namespace Devoluciones.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void ButtonLecturaPrendas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LecturaPrendasPage());
        }

        private void ButtonCerradoCaja_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CerradoCajasPage());
        }

        private void ButtonAsignacionMatricula_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AsignacionMatriculaPage());
        }

        private void ButtonTraspasos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TraspasosPage());
        }

    }
}