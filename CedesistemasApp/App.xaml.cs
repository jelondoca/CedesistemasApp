using System;
using CedesistemasApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CedesistemasApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
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
