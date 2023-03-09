using RemindRx.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RemindRx.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command AddMedsCommand { get; }
        public Command AddApptCommand { get; }

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            AddMedsCommand = new Command(MedBtnClicked);
            AddApptCommand = new Command(ApptBtnClicked);
        }

        public ICommand OpenWebCommand { get; }

        private async void ApptBtnClicked(object obj) //This is where we change the views that the Apt button changes
        {
            await Shell.Current.GoToAsync(nameof(AddAppointmentPage));
        }

        private async void MedBtnClicked(object obj) //This is where we change the views that the Meds button changes
        {
            await Shell.Current.GoToAsync(nameof(AddMedicationPage));
        }
    }
}