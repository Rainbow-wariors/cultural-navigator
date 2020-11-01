using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigator.Locked
{
    public class LockedLoginPage : ContentPage
    {
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Shell.Current.DisplayAlert("Assertion", $"This page not allowed now", "Ok");
            await Shell.Current.GoToAsync("///login/authorization");
        }
    }
}
