using System;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RemindRx.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        //SRC: https://github.com/xamarin/xamarin-forms-samples/blob/main/Navigation/Pop-ups/WorkingWithPopups/ActionSheetPage.xaml.cs
        //Quick suggestion suggests an async task ... function() to handle events ... for any event. Do not fall for its tricks, the below is fine - Clippy fails
        async void btnAlertModal_Click(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "You have been alerted", "OK");
        }

        async void OnActionSheetClicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
            Debug.WriteLine("Action: " + action);
        }
    }
}