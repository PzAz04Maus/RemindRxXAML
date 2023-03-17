using RemindRx.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RemindRx.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingsPage : ContentPage
	{
        String skin = "";
        public SettingsPage ()
		{
			InitializeComponent ();
            BindingContext = new SettingsViewModel();
            languages.Items.Add("English");
			languages.Items.Add("Español");
			themes.Items.Add("Blue");
            themes.Items.Add("Yellow");
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void languages_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Picker picker = (Picker)sender;

            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


            if ((string)picker.SelectedItem == "Blue")
            {
                App.Current.Resources["Pale"] = Color.FromHex("E6f6fc");
                App.Current.Resources["Primary"] = Color.FromHex("84c4dc");
                App.Current.Resources["Disabled"] = Color.FromHex("3883a0");
                App.Current.Resources["Buttons"] = Color.FromHex("84c4dc");
            }
            else if ((string)picker.SelectedItem == "Yellow")
            {
                App.Current.Resources["Pale"] = Color.FromHex("eff2d8");
                App.Current.Resources["Primary"] = Color.FromHex("e8f2a5");
                App.Current.Resources["Disabled"] = Color.FromHex("dced6d");
                App.Current.Resources["Buttons"] = Color.FromHex("dde01d");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
        }
    }
}