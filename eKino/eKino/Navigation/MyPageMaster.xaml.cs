using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKino.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPageMaster : ContentPage
    {
        public ListView ListView;

        public MyPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyPageMasterViewModel();
            ListView = MenuItemsListView;

        }
        class MyPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyPageMenuItem> MenuItems { get; set; }

            public MyPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MyPageMenuItem>(new[]
                {
                    new MyPageMenuItem { Title = "Prijava", ImageSource="login.png", TargetType = typeof(LoginPage) },
                    new MyPageMenuItem { Title = "Profil", ImageSource="profile.png", TargetType = typeof(Views.Clan.ProfilePage) },
                    new MyPageMenuItem { Title = "Filmovi", ImageSource="movie.png", TargetType = typeof(Views.Film.FilmoviPage) },
                    new MyPageMenuItem { Title = "Projekcije", ImageSource="projection.png", TargetType = typeof(Views.Projekcija.ProjekcijePage) },
                    new MyPageMenuItem { Title = "Rezervacije", ImageSource = "reservation.png", TargetType = typeof(Views.Rezervacija.RezervacijaMainPage)},
                    new MyPageMenuItem { Title = "Za Vas", ImageSource = "movie.png", TargetType = typeof(Views.Preporuka.PreporuceniFilmovi) }

                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}