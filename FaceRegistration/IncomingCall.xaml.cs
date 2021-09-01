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
    public partial class IncomingCall : ContentPage
    {
        public IncomingCall()
        {
            InitializeComponent();
            camera.Source = ImageSource.FromResource("FaceRegistration.assets.normal_u394.png");
            answer.Source = ImageSource.FromResource("FaceRegistration.assets.normal_u400.png");
            camera.Aspect = Aspect.AspectFill;
            accept.Aspect = Aspect.AspectFill;
            decline.Aspect = Aspect.AspectFill;
            
            image.Source = ImageSource.FromResource("FaceRegistration.assets.normal_u409.png");
            accept.Source = ImageSource.FromResource("FaceRegistration.assets.normal_u411.png");
            decline.Source = ImageSource.FromResource("FaceRegistration.assets.normal_u414.png");
            
        }

        private void Button_Answer(object sender, EventArgs e)
        {
           
        }

        private void Button_Accept(object sender, EventArgs e)
        {
           
        }

        private void Button_Decline(object sender, EventArgs e)
        {
            
        }
    }
}