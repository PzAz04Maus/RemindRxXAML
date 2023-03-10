using RemindRx.Models;
using RemindRx.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RemindRx.ViewModels
{
    public class ContactsViewModel : BaseViewModel
    {
        private EContact _selectedItem;
        public ObservableCollection<EContact> Items { get; }
        public Command NewContactCommand { get; }

        public Command AddMedsCommand { get; }
        public Command AddApptCommand { get; }
        // public Command ContactsCommand { get; }

        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Item> ItemTapped { get; }

        public ContactsViewModel()
        {
            Title = "About";
            NewContactCommand = new Command(OnNewContact);
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            AddMedsCommand = new Command(MedBtnClicked);
            AddApptCommand = new Command(ApptBtnClicked);

            Items = new ObservableCollection<EContact>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            //ItemTapped = new Command<Item>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);
        }

        public ICommand OpenWebCommand { get; }

        private async void OnNewContact(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewContactPage));
        }

        private async void ApptBtnClicked(object obj) //This is where we change the views that the Apt button changes
        {
            await Shell.Current.GoToAsync(nameof(AddAppointmentPage));
        }

        private async void MedBtnClicked(object obj) //This is where we change the views that the Meds button changes
        {
            await Shell.Current.GoToAsync(nameof(AddMedicationPage));
        }
        /*private async void ContactsBtnClicked(object obj) //This is where we change the views that the Meds button changes
        {
            await Shell.Current.GoToAsync(nameof(ContactsPage));
        }*/

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStoreContact.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public EContact SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                //OnItemSelected(value);
            }
        }

        private async void OnAddItem(object obj) //This is where we change the views that the add item button changes
        {
            await Shell.Current.GoToAsync(nameof(AddAppointmentPage));
        }

        /*async void OnItemSelected(EContact item)
        {
           
                return;

            // This will push the ItemDetailPage onto the navigation stack
            //await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }*/
    }
}