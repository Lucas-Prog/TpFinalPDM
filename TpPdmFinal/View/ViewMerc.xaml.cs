using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpPdmFinal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TpPdmFinal.View
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewMerc : ContentPage
    {
        public Mercadoria mercadoria;
        public ViewMerc()
        {
            InitializeComponent();
        }

        public ViewMerc(Mercadoria merc)
        {
            mercadoria = App.MercadoriaModel.GetMercadoria(merc.Id);
            InitializeComponent();
        }

        private void OnEditTapped(object sender, EventArgs args)
        {
            Navigation.PushAsync(new EditMerc(mercadoria));
        }

        private void OnDeleteTapped(object sender, EventArgs args)
        {
            App.MercadoriaModel.RemoverMercadoria(mercadoria.Id);
            Navigation.PopAsync();
        }

        private void setData()
        {
            lblName.Text = mercadoria.name;
            lblPeso.Text = mercadoria.wheight.ToString();
            lblProdEmail.Text = mercadoria.prodEmail;
            lblProdName.Text = mercadoria.prodName;
            lblNCM.Text = mercadoria.NCM;
        }

        protected override void OnAppearing()
        {
            mercadoria = App.MercadoriaModel.GetMercadoria(mercadoria.Id);

            setData();
        }
    }
}