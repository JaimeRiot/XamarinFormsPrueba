using APIPrueba.UIForms.Views.MenuApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APIPrueba.UIForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {

            InitializeComponent();
            
        }

        private async void SeeProducts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductsPageView());
        }

        private async void SeeGet(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntradaProductView());
        }

        private async void SeeSale(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SalidaProductView());
        }
    }
}