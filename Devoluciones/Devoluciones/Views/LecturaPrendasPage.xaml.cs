using Devoluciones.Models;
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
    public partial class LecturaPrendasPage : ContentPage
    {
        public Articulo articulo { get; set; }

        public LecturaPrendasPage()
        {
            InitializeComponent();
        }

        private void OnButtonMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
        }

        private void OnEntryArticulo_Completed(object sender, EventArgs e)
        {
            string codigoArticulo = ((Entry)sender).Text;
            if (string.IsNullOrEmpty(codigoArticulo))
            {
                SetVisibility_StackLayout_ArticuloNombre(false);
                SetVisibility_ImageArticulo(false);
            }
            else
            {
                articulo = GetArticulo(codigoArticulo);
                this.lblArticuloNombre.Text = codigoArticulo;
                SetVisibility_StackLayout_ArticuloNombre(false);
                SetVisibility_ImageArticulo(false);
                SetVisibility_StackLayout_ArticuloNombre(true);
                SetVisibility_ImageArticulo(true);
            }
        }


        private void SetVisibility_StackLayout_ArticuloNombre(bool visibility)
        {
            this.slArticuloNombre.IsVisible = visibility;
        }

        private void SetVisibility_ImageArticulo(bool visibility)
        {
            if (visibility)
            {
                this.imgArticulo.Source = ImageSource.FromUri(new Uri(articulo.ImageURL));
            }
            this.imgArticulo.IsVisible = visibility;
        }



        private Articulo GetArticulo(string codigoArticulo)
        {
            return new Articulo
            {
                Codigo = codigoArticulo,
                Nombre = codigoArticulo,
                ImageURL = "https://placeimg.com/640/480/any"
            };
        }


    }
}