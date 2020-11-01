using Android.Content;
using Android.OS;
using AndroidX.Fragment.App;
using Navigator.Droid.Renderers;
using Navigator.Droid.Renderers.Elements;
using Navigator.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TransitionShell), typeof(TransitionShellRenderer))]
namespace Navigator.Droid.Renderers
{
    // TODO: stretch tabs
    // TODO: fix tab transition animation
    public class TransitionShellRenderer : ShellRenderer
    {
        public TransitionShellRenderer(Context context) : base(context)
        {
            StatusBarColor = Color.Gray;
        }

        protected override void SetupPageTransition(FragmentTransaction transaction)
        {
            transaction.SetCustomAnimations(Resource.Animation.scale_in, Resource.Animation.scale_out);
        }
        
        protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
        {
            return new BottomNavAppearance(this, shellItem, ((TransitionShell)Element).TabBarIconForeground);
        }
        
        protected override IShellTabLayoutAppearanceTracker CreateTabLayoutAppearanceTracker(ShellSection shellSection)
        {
            return new TabLayoutAppearance(this, ((TransitionShell)Element).TabTitleEmphasizerColor);
        }
    }
}