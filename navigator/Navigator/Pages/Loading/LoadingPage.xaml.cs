using Navigator.ViewModels;
using System.Diagnostics;
using Xamarin.Forms;

namespace Navigator.Pages.Loading
{
    public partial class LoadingPage : ContentPage
    {
        public LoadingPage()
        {
            BindingContext = new LoadingVm();

            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            await Shell.Current.GoToAsync("///login/authorization");
        }
    }
}
