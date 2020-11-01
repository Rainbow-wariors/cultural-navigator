using Navigator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigator.Pages.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorizationPage : ContentPage
    {
        public AuthorizationPage()
        {
            BindingContext = new AuthorizationVm();

            InitializeComponent();

            EmailEntry.ReturnCommand = new Command(() => PasswordEntry.Focus());

            var registerLabelGestureRecognizer = new TapGestureRecognizer();
            registerLabelGestureRecognizer.Tapped += async (s, e) =>
            {
                await Shell.Current.GoToAsync("///login/registration");
            };
            RegisterLabel.GestureRecognizers.Add(registerLabelGestureRecognizer);

            var forgotPasswordLabelGestureRecognizer = new TapGestureRecognizer();
            forgotPasswordLabelGestureRecognizer.Tapped += async (s, e) =>
            {
                await Shell.Current.GoToAsync("///login/recovery");
            };
            ForgotPasswordLabel.GestureRecognizers.Add(forgotPasswordLabelGestureRecognizer);
        }
    }
}