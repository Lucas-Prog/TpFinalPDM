using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TpPdmFinal.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Create : ContentPage
    {
        private int mercId = 0;
        public Create()
        {
            InitializeComponent();
        }

        public Create(int Id)
        {
            InitializeComponent();
            var mercadoria = App.MercadoriaModel.GetMercadoria(Id);
            mercName.Text = mercadoria.name;
            mercHeight.Text = mercadoria.wheight.ToString();
            prodName.Text = mercadoria.prodName;
            prodEmail.Text = mercadoria.prodEmail;
            NCM.Text = mercadoria.NCM;
            mercId = mercadoria.Id;
        }

        public void OnSave(object sender, EventArgs e)
        {
            TpPdmFinal.Model.Mercadoria mercadoria = new TpPdmFinal.Model.Mercadoria()
            {
                name = mercName.Text,
                wheight = float.Parse(mercHeight.Text),
                prodName = prodName.Text,
                prodEmail = prodEmail.Text,
                NCM = NCM.Text,
                Id = mercId
            };
            Limpar();
            App.MercadoriaModel.SalvarMercadoria(mercadoria);
            Navigation.PopAsync();
        }

        public void OnCancel(object sender, EventArgs e)
        {
            Limpar();
            Navigation.PopAsync();
        }

        public void Limpar()
        {
            mercName.Text = prodName.Text = prodEmail.Text = NCM.Text = mercHeight.Text = string.Empty;
        }
    }
}