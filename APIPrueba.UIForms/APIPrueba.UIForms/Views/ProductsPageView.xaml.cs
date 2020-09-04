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
    public partial class ProductsPageView : ContentPage
    {
        public ProductsPageView()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddProductView());
        }
    }
}