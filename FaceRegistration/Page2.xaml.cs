using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FaceRegistration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

            
            territory.Source = ImageSource.FromResource("FaceRegistration.assets.u258.png");
            house.Source = ImageSource.FromResource("FaceRegistration.assets.u259.png");
         

            phone.Source = ImageSource.FromResource("FaceRegistration.assets.u260.png");
            home.Source = ImageSource.FromResource("FaceRegistration.assets.u261.png");
            settings.Source = ImageSource.FromResource("FaceRegistration.assets.u262.png");
        }


        private void phone_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void settings_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void home_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }



        private void Territory_Tapped(object sender, EventArgs e)
        {
            territory.Source = ImageSource.FromResource("FaceRegistration.assets.u266.png");
            territory_text.Text = "The door is open";

        }

        private void House_Tapped(object sender, EventArgs e)
        {
            house.Source = ImageSource.FromResource("FaceRegistration.assets.u266.png");
            house_text.Text = "The door is open";
        }
    }
}