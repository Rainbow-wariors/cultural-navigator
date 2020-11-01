using Android.Content;
using Android.Graphics.Drawables;
using Navigator.Droid.Renderers;
using Navigator.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]
namespace Navigator.Droid.Renderers
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        public BorderlessEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null) return;
            var gradientDrawable = new GradientDrawable();
            gradientDrawable.SetColor(global::Android.Graphics.Color.Transparent);
            Control.Background = gradientDrawable;
        }
    }
}