using RemindRx.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RemindRx.ViewModels
{
    [QueryProperty(nameof(tod), nameof(tod))]
    public class NewContactViewModel : BaseViewModel
    {
        private string tod;
        private string text;
        private string description;
        private string date;

        public NewContactViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(text)
                && !String.IsNullOrWhiteSpace(description);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string ToD
        {
            get => tod;
            set=> SetProperty(ref tod, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        public async void LoadItemId(string id)
        {
            try
            {
                var item = await DataStore.GetItemAsync(tod);
                ToD = item.ToD;
                Text = item.Text;
                Description = item.Description;
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Failed to load contact, {0}", ex);
            }
        }

        private async void OnSave()
        {
            EContact newContact = new EContact()
            {
                Id = Guid.NewGuid().ToString(),
                Name = Text,
                Relation = Description,
                Number = ToD
            };

            await DataStoreContact.AddItemAsync(newContact);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
