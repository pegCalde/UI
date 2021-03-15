using System;
using UI.Models;
using UI.ViewModels;
using Xamarin.Forms;

namespace UI
{
    public partial class MainPage : ContentPage
    {
        int nbView = 0;

        public MainPage()
        {
            //InitializeComponent();
            BindingContext = new ProfileViewModel(new User());
        }
    }
}
