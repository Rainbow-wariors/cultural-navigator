using Xamarin.Forms;

namespace Navigator.Renderers
{
    public class TransitionShell : Shell
    {
        public static readonly BindableProperty TabBarIconForegroundProperty = BindableProperty.Create(nameof(TabBarIconForeground),
            typeof(Brush), typeof(TransitionShell), default(Brush));
        
        public Brush TabBarIconForeground
        {
            get => (Brush)GetValue(TabBarIconForegroundProperty);
            set => SetValue(TabBarIconForegroundProperty, value);
        }

        public static readonly BindableProperty TabTitleEmphasizerColorProperty = BindableProperty.Create(
            nameof(TabTitleEmphasizerColor),
            typeof(Color), typeof(TransitionShell), default(Brush));
        
        public Color TabTitleEmphasizerColor
        {
            get => (Color)GetValue(TabTitleEmphasizerColorProperty);
            set => SetValue(TabTitleEmphasizerColorProperty, value);
        }
    }
}