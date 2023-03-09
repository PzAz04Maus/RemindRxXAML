using RemindRx.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RemindRx.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {

        public Command SettingsCommand { get; }

        public Command AddMedsCommand { get; }
        public Command AddApptCommand { get; }

        public AboutViewModel()
        {
            Title = "About";
            SettingsCommand = new Command(OnSettings);
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            AddMedsCommand = new Command(MedBtnClicked);
            AddApptCommand = new Command(ApptBtnClicked);
        }

        public ICommand OpenWebCommand { get; }

        private async void OnSettings(object obj)
        {
            await Shell.Current.GoToAsync(nameof(SettingsPage));
        }

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