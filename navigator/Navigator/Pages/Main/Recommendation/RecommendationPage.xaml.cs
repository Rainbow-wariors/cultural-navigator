using Navigator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigator.Pages.Main.Recommendation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecommendationPage : ContentPage
    {
        public RecommendationPage()
        {
            InitializeComponent();
        }

        public RecommendationPage(BaseViewModel viewModel)
        {
            BindingContext = viewModel;
            InitializeComponent();
        }
    }
}