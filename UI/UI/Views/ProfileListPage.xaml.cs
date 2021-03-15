using UI.ViewModels;
using Xamarin.Forms;


namespace UI
{
    public partial class ProfileListPage : ContentPage
    {
        public ProfileListPage()
        {
            InitializeComponent();
            BindingContext = new ProfileListPageViewModel();
        }
    }
}