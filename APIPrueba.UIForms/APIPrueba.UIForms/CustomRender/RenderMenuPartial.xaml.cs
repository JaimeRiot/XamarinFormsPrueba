using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APIPrueba.UIForms.CustomRender
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RenderMenuPartial : ContentView
    {
        public RenderMenuPartial()
        {
            InitializeComponent();
            LblTitle.Text = Preferences.Get("pageTitle", string.Empty);
        }
        private async void ImgMenu_Tapped(object sender, EventArgs e)
        {
            GridOverlay.IsVisible = true;
            await SlMenu.TranslateTo(0, 0, 400, Easing.Linear);
        }

        private void TapCloseMenu_Tapped(object sender, EventArgs e)
        {
            CloseHamBurgerMenu();
        }

        private async void CloseHamBurgerMenu()
        {
            await SlMenu.TranslateTo(-250, 0, 400, Easing.Linear);
            GridOverlay.IsVisible = false;
        }
    }
}