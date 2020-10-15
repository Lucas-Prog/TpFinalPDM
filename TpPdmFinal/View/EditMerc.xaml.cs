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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditMerc : ContentPage
    {
        public Mercadoria mercadoria;
        public EditMerc()
        {
            InitializeComponent();
        }
        public EditMerc(Mercadoria merc)
        {
            mercadoria = merc;
            InitializeComponent();

            lblName.Text = mercadoria.name;
            lblPeso.Text = mercadoria.wheight.ToString();
            lblProdEmail.Text = mercadoria.prodEmail;
            lblProdName.Text = mercadoria.prodName;
            lblNCM.Text = mercadoria.NCM;
        }

        private void OnSaveClicked(object sender, EventArgs args)
        {
            TpPdmFinal.Model.Mercadoria mercadoria = new TpPdmFinal.Model.Mercadoria()
            {
                name = lblName.Text,
                wheight = float.Parse(lblPeso.Text),
                prodName = lblProdName.Text,
                prodEmail = lblProdEmail.Text,
                NCM = lblNCM.Text,
                Id = this.mercadoria.Id
            };
            Limpar();
            App.MercadoriaModel.UpdateMercadoria(mercadoria);
            Navigation.PopAsync();
        }

        private void OnCancelClicked(object sender, EventArgs args)
        {
            Limpar();
            Navigation.PopAsync();
        }

        public void Limpar()
        {
            lblName.Text = lblPeso.Text = lblProdEmail.Text = lblProdName.Text = lblNCM .Text = string.Empty;
        }
    }
}