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
	}
}