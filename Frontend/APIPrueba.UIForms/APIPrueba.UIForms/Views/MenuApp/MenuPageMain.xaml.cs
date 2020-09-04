using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APIPrueba.UIForms.Views.MenuApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPageMain : MasterDetailPage
    {
        public MenuPageMain()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            myPageMain();
        }

        public void myPageMain()
        {
            Detail = new NavigationPage(new HomeView());

            List<Options> options = new List<Options>
            {
                new Options{ page=new AddProductView(), Title="Productos", Icon = ((char)0xf0ae).ToString() },
                new Options{ page= null, Title="Reportes", Icon = ((char)0xf0ae).ToString() },
                new Options{ page=null, Title="Perfil", Icon = ((char)0xf0ae).ToString() },
                new Options{ page=null, Title="Configuracion", Icon = ((char)0xf0ae).ToString() },
                new Options{ page=null, Title="Cerrar Sesión", Icon = ((char)0xf0ae).ToString() },
            };
            listPageMain.ItemsSource = options;
        }
        private async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var option = e.SelectedItem as Options;
            if (option.page != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(option.page);
            }
            else if (option.page == null && option.Title == "Cerrar Sesión")
            {

                var result = await DisplayAlert("Confirmar", "Estas seguro de cerrar sesión", "SI", "NO");
                if (result)
                {
                    await Navigation.PushAsync(new MainPage());
                }
                else
                {
                    return;
                }
            }
        }
    }
}