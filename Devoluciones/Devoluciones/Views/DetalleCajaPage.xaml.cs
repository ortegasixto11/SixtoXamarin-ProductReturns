using Devoluciones.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Devoluciones.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleCajaPage : ContentPage
    {
        public ObservableCollection<Articulo> Articulos { get; set; }
        public Caja Caja { get; set; }

        public DetalleCajaPage(Caja caja)
        {
            InitializeComponent();
            this.Caja = caja;

            this.lblCaja.Text = Caja.Codigo;
            this.lblTemporada.Text = Caja.Temporada.ToString();

            this.Articulos = Articulo.GetArticulosFake();
            this.cvArticulos.ItemsSource = this.Articulos;
            RecalculateHeight_CollectionView_Articulos();
        }

        private void OnButtonVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CerradoCajasPage());
        }

        private void RecalculateHeight_CollectionView_Articulos()
        {
            this.cvArticulos.ItemsSource = Articulos;
            this.cvArticulos.HeightRequest = 30 * Articulos.Count();
        }

        private void OnLabel_RemoveArticulo_Tapped(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            TapGestureRecognizer gesture = (TapGestureRecognizer)label.GestureRecognizers[0];
            Articulo articulo = (Articulo)gesture.CommandParameter;
            RemoveArticulo(articulo);
        }

        private void RemoveArticulo(Articulo articulo)
        {
            Articulos.Remove(articulo);
            RecalculateHeight_CollectionView_Articulos();
        }

        private void OnLabel_DetalleArticulo_Tapped(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            TapGestureRecognizer gesture = (TapGestureRecognizer)label.GestureRecognizers[0];
            Articulo articulo = (Articulo)gesture.CommandParameter;
            Navigation.PushAsync(new DetalleArticuloPage(articulo, Caja));
        }
    }
}