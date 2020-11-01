using Navigator.Pages.Main.Recommendation;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigator.ViewModels
{
    public class AuthorizationVm : BaseViewModel
    {
        private Command _loginCommand;
        public Command LoginCommand =>
            _loginCommand ??= new Command(async () =>
            {
                await Shell.Current.GoToAsync("///main/navigator/tags");
            });
    }
}
