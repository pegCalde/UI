using System;
using System.Windows.Input;
using UI.Models;
using Xamarin.Forms;

namespace UI.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        string username;
        string datebirth;
        string birthplace;
        string description;
        string nbView;
        string nbShare;
        string pp;
        string couv;

        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }
        public string Datebirth
        {
            get { return datebirth; }
            set { SetProperty(ref datebirth, value); }
        }
        public string Birthplace
        {
            get { return birthplace; }
            set { SetProperty(ref birthplace, value); }
        }
        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }
        public string NbView
        {
            get { return nbView; }
            set { SetProperty(ref nbView, value); }
        }
        public string NbShare
        {
            get { return nbShare; }
            set { SetProperty(ref nbShare, value); }
        }
        public string PP
        {
            get { return pp; }
            set { SetProperty(ref pp, value); }
        }
        public string Couv
        {
            get { return couv; }
            set { SetProperty(ref couv, value); }
        }


        public ICommand OnButtonSharedClickedCommand
        {
            get
            {
                return new Command(ButtonSharedClicked);
            }
        }

        void ButtonSharedClicked()
        {
            int nbShare = Convert.ToInt32(NbShare);

            nbShare++;
            NbShare = Convert.ToString(nbShare);
        }

        public ProfileViewModel(User user)
        {
            Username = user.Username;
            Description = user.Description;
            Datebirth = user.Datebirth;
            Birthplace = user.BirthPlace;
            NbView = user.NbView;
            NbShare = user.NbShare;
            PP = user.PP;
            Couv = user.Couv;
        }
    }
}
