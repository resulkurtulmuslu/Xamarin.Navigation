using Mobile.Navigation.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.App.LauncherActivity;

namespace Mobile.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView : ContentPage
    {
        ObservableCollection<Movie> movies = new ObservableCollection<Movie>();

        public ListView()
        {
            InitializeComponent();

            movies.Add(new Movie { Name = "Son hava bükücü" , Desciription = "Follows the adventures of Aang, a young successor to a long line of Avatars, who must master all four elements and stop the Fire Nation from enslaving the Water Tribes and the Earth Kingdom.", Title = "Son hava bükücü" , ImageUrl= "https://m.media-amazon.com/images/M/MV5BMTM1NjE0NDA0MV5BMl5BanBnXkFtZTcwODE4NDg1Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg" });
            movies.Add(new Movie { Name = "Baba", Desciription = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", Title = "Baba", ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY268_CR3,0,182,268_AL_.jpg" });
            movies.Add(new Movie { Name = "Soysuzlar Çetesi", Desciription = "In Nazi-occupied France during World War II, a plan to assassinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same.", Title = "Soysuzlar Çetesi", ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTJiNDEzOWYtMTVjOC00ZjlmLWE0NGMtZmE1OWVmZDQ2OWJhXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_UX182_CR0,0,182,268_AL_.jpg" });

            lst_View.ItemsSource = movies;
        }

        async void lst_View_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Movie;
            if (item == null) return;

            await Navigation.PushAsync(new DetailPage(item));
            lst_View.SelectedItem = null;
        }
    }
}