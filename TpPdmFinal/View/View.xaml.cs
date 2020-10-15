using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TpPdmFinal.ViewModel;
using TpPdmFinal.Model;

namespace TpPdmFinal.View
{
    public partial class View : ContentPage
    {
        Mercadoria_ViewModel vmMercadoria;
        public View()
        {
            vmMercadoria = new Mercadoria_ViewModel();
            BindingContext = vmMercadoria;            
            InitializeComponent();
        }
         private void OnMercTapped(object sender, ItemTappedEventArgs args)
        {
            Navigation.PushAsync(new ViewMerc(args.Item as Mercadoria));
        }
    }
}