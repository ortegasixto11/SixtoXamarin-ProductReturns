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
    public partial class CerradoCajasPage : ContentPage
    {
        public ObservableCollection<Caja> Cajas { get; set; }


        public CerradoCajasPage()
        {
            InitializeComponent();
            Cajas = Caja.GetCajasFake();
            this.cvCajas.ItemsSource = Cajas;
            RecalculateHeight_CollectionView_Cajas();
        }

        private void OnButtonMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
        }

        private void RecalculateHeight_CollectionView_Cajas()
        {
            this.cvCajas.ItemsSource = Cajas;
            this.cvCajas.HeightRequest = 30 * Cajas.Count();
        }

        private void OnLabel_RemoveCaja_Tapped(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            TapGestureRecognizer gesture = (TapGestureRecognizer)label.GestureRecognizers[0];
            Caja caja = (Caja)gesture.CommandParameter;
            RemoveCaja(caja);
        }

        private void RemoveCaja(Caja caja)
        {
            Cajas.Remove(caja);
            RecalculateHeight_CollectionView_Cajas();
        }

        private void OnLabel_DetalleCaja_Tapped(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            TapGestureRecognizer gesture = (TapGestureRecognizer)label.GestureRecognizers[0];
            Caja caja = (Caja)gesture.CommandParameter;
            Navigation.PushAsync(new DetalleCajaPage(caja));
        }
    }
}