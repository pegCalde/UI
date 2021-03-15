using UI.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace UI.ViewModels
{
    public class ProfileListPageViewModel : BaseViewModel
    {
        ObservableCollection<User> users = new ObservableCollection<User>();
        User userSelected;

        public ObservableCollection<User> Users
        {
            get { return users; }

            set { SetProperty(ref users, value); }
        }

        public ProfileListPageViewModel()
        {
            Users.Add(new User
            {
                Username = "Perceval",
                Description = "Chef de clan des semi-croustillants"
            });
            Users.Add(new User
            {
                Username = "Arthur",
                Description = "Roi de Bretagne"
            });
            Users.Add(new User
            {
                Username = "Guenièvre",
                Description = "Reine de Bretagne, femme d'Arhtur"
            });
            Users.Add(new User
            {
                Username = "Karadoc",
                Description = "Meilleur ami de Perceval"
            });

        }       

        public User UserSelected
        {
            get { return userSelected; }
            set {
                SetProperty(ref userSelected, value);

                if(value != null) {
                    Device.BeginInvokeOnMainThread(async () => {
                        await Application.Current.MainPage.DisplayAlert("User selected", $"You clicked on {value.Username}", "OK");
                        UserSelected = null;
                    });
                }
            }
        }
    }
}