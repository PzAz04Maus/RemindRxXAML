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

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<MockDataStoreContact>();
            MainPage = new AppShell();
        }
        public void ChangeTheme(string uri)
        {
            ThemeDictionary.MergedDictionaries.Clear();
            var resource = new ResourceDictionary();
            var source = new Uri(uri, UriKind.Relative);
            resource.SetAndLoadSource(source, uri, this.GetType().GetTypeInfo().Assembly, null);
            ThemeDictionary.MergedDictionaries.Add(resource);
            ThemeDictionary.MergedDictionaries.ElementAt(0).Source = source;
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
