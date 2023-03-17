using RemindRx.Services;
using RemindRx.Views;
using System;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RemindRx
{
    public partial class App : Application
    {
        ResourceDictionary appSkin = new ResourceDictionary();
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<MockDataStoreContact>();
            MainPage = new AppShell();
        }

        public void ChangeTheme(string skin)
        {
            //appSkin.Source = new Uri(skin);
            //Application.Current.Resources.MergedDictionaries.Clear();
            //Application.Current.Resources.MergedDictionaries.Add(appSkin);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
