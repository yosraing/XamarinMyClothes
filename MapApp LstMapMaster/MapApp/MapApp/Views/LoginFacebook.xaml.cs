using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookLogin;
using GoogleLogin.Views;
using Xamarin.Forms;
using MapApp.Views;
using Plugin.TextToSpeech;

namespace MapApp.Views
{
    public partial class LoginFacebook : ContentPage
    {
        public LoginFacebook()
        {
            InitializeComponent();
        }
        private async void LoginWithFacebook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FacebookProfilePage());
            var tt = "vous connecter avec facebook";
            CrossTextToSpeech.Current.Speak(tt);
        }

        private async void LoginWithGoogle_OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GoogleProfileCsPage());
            var tt1 = "vous connecter avec google";
            CrossTextToSpeech.Current.Speak(tt1);
        }
    }
}

