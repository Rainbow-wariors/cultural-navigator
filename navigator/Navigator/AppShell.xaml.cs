using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Navigator.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : TransitionShell
    {
        public AppShell()
        {
            InitializeComponent();
        }
    }
}