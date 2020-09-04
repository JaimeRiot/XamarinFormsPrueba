using APIPrueba.UIForms.Views;
using APIPrueba.UIForms.Views.MenuApp;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APIPrueba.UIForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MenuPageMain();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
