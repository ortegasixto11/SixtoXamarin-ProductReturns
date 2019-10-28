using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Devoluciones.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TraspasosPage : ContentPage
    {
        public TraspasosPage()
        {
            InitializeComponent();
        }

        private void ButtonMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
        }
    }
}