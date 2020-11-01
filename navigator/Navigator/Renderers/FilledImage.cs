using Xamarin.Forms;

namespace Navigator.Renderers
{
    public class FilledImage : Image
    {
        public static readonly BindableProperty ForegroundProperty = BindableProperty.Create(nameof(Foreground),
            typeof(Color), typeof(FilledImage), default(Color));
        
        public Color Foreground
        {
            get => (Color)GetValue(ForegroundProperty);
            set => SetValue(ForegroundProperty, value);
        }

        public new static readonly BindableProperty SourceProperty = BindableProperty.Create(nameof(Source), typeof(string),
            typeof(FilledImage), default(string));

        public new string Source
        {
            get => (string)GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }
    }
}