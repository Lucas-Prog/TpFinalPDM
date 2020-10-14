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

        public void OnSave(object sender, EventArgs e)
        {
            TpPdmFinal.Model.Mercadoria mercadoria = new TpPdmFinal.Model.Mercadoria()
            {
                name = mercName.Text,
                wheight = float.Parse(mercHeight.Text),
                prodName = prodName.Text,
                prodEmail = prodEmail.Text,
                NCM = NCM.Text
            };
            limpar();
            App.MercadoriaModel.SalvarMercadoria(mercadoria);
            Navigation.PopAsync();
        }

        public void OnCancel(object sender, EventArgs e)
        {
            limpar();
            Navigation.PopAsync();
        }

        public void limpar()
        {
            mercName.Text = prodName.Text = prodEmail.Text = NCM.Text = string.Empty;
            mercHeight.Text = string.Empty;
        }
    }
}