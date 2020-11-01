using Navigator.Pages.Main.Recommendation;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigator.ViewModels
{
    public class RecommendationTagsVm : BaseViewModel
    {
        public RecommendedBooksVm RecommendedBooks;
        public RecommendationPage RecommendedBooksPage;

        public RecommendationTagsVm()
        {
            RecommendedBooks = new RecommendedBooksVm();
            RecommendedBooksPage = new RecommendationPage(RecommendedBooks);
        }

        private Command _goToRecommendationsCommand;
        public Command GoToRecommendationsCommand =>
            _goToRecommendationsCommand ??= new Command(async (p) =>
            {
                switch((string)p)
                {
                    case "":
                        break;

                    case "books":
                        await Shell.Current.Navigation.PushAsync(RecommendedBooksPage);
                        break;

                    case "inaccessible":
                        await Shell.Current.Navigation.PushAsync(new InaccessibleRecommendationPage());
                        break;

                    default:
                        throw new ArgumentException();
                }
            });
    }
}
