using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using APIPrueba.UIForms.CustomRender;
using APIPrueba.UIForms.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using static Java.Util.ResourceBundle;

[assembly: ExportRenderer(typeof(UIEntryRender), typeof(UIEntryRenderer))]
namespace APIPrueba.UIForms.Droid
{
    [Obsolete]
    class UIEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.White
                    );
            }
        }
    }
}