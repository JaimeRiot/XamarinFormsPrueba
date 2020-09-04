using APIPrueba.UIForms.Models;
using APIPrueba.UIForms.ViewModels;
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
    public partial class EditProductView : ContentPage
    {
        public EditProductView(Product product)
        {
            InitializeComponent();
            BindingContext = new UpdateProductViewModel(product);
        }
    }
}