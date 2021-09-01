using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FaceRegistration
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new IncomingCall());
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
