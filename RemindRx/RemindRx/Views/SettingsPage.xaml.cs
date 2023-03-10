using RemindRx.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RemindRx.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingsPage : ContentPage
	{
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

            if((string)picker.SelectedItem == "Blue")
            {
                var app = (App)Application.Current;
                app.ChangeTheme("blueskin.xaml");
            }
            else if ((string)picker.SelectedItem == "Yellow")
               {
                    var app = (App)Application.Current;
                    app.ChangeTheme("yellowskin.xaml");
                }
        }
    }
}