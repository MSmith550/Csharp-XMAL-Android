using System;
using TabletLearner2.Services;
using TabletLearner2.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabletLearner2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
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
