using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TpPdmFinal.ViewModel;

namespace TpPdmFinal.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewMainPage : ContentPage
    {
        Mercadoria_ViewModel vmMercadoria;
        public NewMainPage()
        {
            vmMercadoria = new Mercadoria_ViewModel();
            BindingContext = vmMercadoria;
            InitializeComponent();
        }

        private void OnCreate(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Create());
        }

        private void OnView(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View());
        }
    }
}