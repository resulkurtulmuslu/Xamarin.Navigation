using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationModelPage : ContentPage
    {
        public NavigationModelPage(string Name)
        {
            InitializeComponent();

            lbl_Name.Text = Name;
        }
    }
}