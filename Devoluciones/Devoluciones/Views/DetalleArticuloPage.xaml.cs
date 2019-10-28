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
    public partial class DetalleArticuloPage : ContentPage
    {
        public Articulo Articulo { get; set; }
        public Caja Caja { get; set; }

        public DetalleArticuloPage(Articulo articulo, Caja caja)
        {
            InitializeComponent();
            Articulo = articulo;
            Caja = caja;

            this.lblArticuloCodigo.Text = Articulo.Codigo;
            this.lblArticuloNombre.Text = Articulo.Nombre;
            this.imgArticulo.Source = ImageSource.FromUri(new Uri(Articulo.ImageURL));
        }

        private void OnButtonVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetalleCajaPage(Caja));
        }
    }
}