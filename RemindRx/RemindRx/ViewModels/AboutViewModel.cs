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

        public AboutViewModel()
        {
            Title = "About";
            SettingsCommand = new Command(OnSettings);
        }

        public ICommand OpenWebCommand { get; }

        private async void OnSettings(object obj)
        {
            await Shell.Current.GoToAsync(nameof(SettingsPage));
        }
    }
}