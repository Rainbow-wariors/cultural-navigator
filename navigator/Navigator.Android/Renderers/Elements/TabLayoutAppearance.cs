using Google.Android.Material.Tabs;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace Navigator.Droid.Renderers.Elements
{
    public class TabLayoutAppearance : ShellTabLayoutAppearanceTracker
    {
        public Color TabTitleEmphasizerColor;
        
        public TabLayoutAppearance(IShellContext shellContext, Color tabTitleEmphasizerColor) : base(shellContext)
        {
            TabTitleEmphasizerColor = tabTitleEmphasizerColor;
        }

        protected override void SetColors(TabLayout tabLayout, Color foreground, Color background, Color title, Color unselected)
        {
            base.SetColors(tabLayout, foreground, background, title, unselected);

            tabLayout.SetSelectedTabIndicatorColor(TabTitleEmphasizerColor.ToAndroid());
        }
    }
}