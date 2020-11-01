using Navigator.Locked;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigator.Pages.Main.Favorites
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookmarksPage : LockedMainPage
    {
        public BookmarksPage()
        {
            InitializeComponent();
        }
    }
}