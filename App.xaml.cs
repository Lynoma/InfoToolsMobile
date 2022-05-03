using MobileInfoTools.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileInfoTools
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            MainPage page = new MainPage();
            MainPage = new NavigationPage(page);
            MainPage.BindingContext = new MainPageViewModel(MainPage);
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
