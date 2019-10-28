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
    public partial class AsignacionMatriculaPage : ContentPage
    {
        public string PaletCodigo { get; set; }
        public string CajaCodigo { get; set; }
        public ObservableCollection<Caja> Cajas { get; set; }


        public AsignacionMatriculaPage()
        {
            InitializeComponent();
            Cajas = new ObservableCollection<Caja>();
        }

        private void OnButtonMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
        }

        private void OnEntry_Palet_Completed(object sender, EventArgs e)
        {
            PaletCodigo = ((Entry)sender).Text;
        }

        private void OnEntry_Caja_Completed(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PaletCodigo))
            {
                DisplayAlert("Info", "Debe escanear una paleta primero", "Ok");
                this.entryCajaCodigo.Text = "";
                return;
            }
            CajaCodigo = this.entryCajaCodigo.Text;
            AddCaja(CajaCodigo);
            SetVisivibility_StackLayout_Cajas(true);
            Setvisibility_Button_ConfirmarMatricula(true);
            this.entryCajaCodigo.Text = "";
        }

        private void AddCaja(string cajaCodigo)
        {
            Cajas.Add(new Caja { Id = Guid.NewGuid(), Codigo = cajaCodigo });
            RecalculateHeight_CollectionView_Cajas();
        }

        private void RemoveCaja(Caja caja)
        {
            Cajas.Remove(caja);
            if(Cajas.Count() == 0)
            {
                SetVisivibility_StackLayout_Cajas(false);
                Setvisibility_Button_ConfirmarMatricula(false);
            }
            RecalculateHeight_CollectionView_Cajas();
        }

        private void RecalculateHeight_CollectionView_Cajas()
        {
            this.cvCajas.ItemsSource = Cajas;
            this.cvCajas.HeightRequest = 30 * Cajas.Count();
        }

        private void SetVisivibility_StackLayout_Cajas(bool visibility)
        {
            this.slCajas.IsVisible = visibility;
        }

        private void Setvisibility_Button_ConfirmarMatricula(bool visibility)
        {
            this.btnConfirmarMatricula.IsVisible = visibility;
        }

        private void OnLabel_RemoveCaja_Tapped(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            TapGestureRecognizer gesture = (TapGestureRecognizer)label.GestureRecognizers[0];
            Caja caja = (Caja)gesture.CommandParameter;
            RemoveCaja(caja);
        }


    }
}