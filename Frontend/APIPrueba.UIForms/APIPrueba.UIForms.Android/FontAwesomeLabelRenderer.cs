using Android.Graphics;
using APIPrueba.UIForms.CustomRender;
using APIPrueba.UIForms.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FontAwesomeLabel), typeof(FontAwesomeLabelRenderer))]
namespace APIPrueba.UIForms.Droid
{
    [System.Obsolete]
    public class FontAwesomeLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets,
                    "Fonts/" + FontAwesomeLabel.FontAwesomeName + ".otf");
            }
        }
    }
}