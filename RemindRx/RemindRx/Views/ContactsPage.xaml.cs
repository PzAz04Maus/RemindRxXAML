using RemindRx.ViewModels;
using Xamarin.Forms;

namespace RemindRx.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
	{

        ContactsViewModel _viewModel;
        public ContactsPage()
		{
			InitializeComponent();
            BindingContext = _viewModel = new ContactsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}