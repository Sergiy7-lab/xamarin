using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FaceRegistration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource("FaceRegistration.assets.normal_u32.png");
            face.Source = ImageSource.FromResource("FaceRegistration.assets.u73.png");
            
            }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Button_Home(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}