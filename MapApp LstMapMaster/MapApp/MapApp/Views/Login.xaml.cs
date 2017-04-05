using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookLogin.Views;
using GoogleLogin.Views;
using Plugin.TextToSpeech;
using Xamarin.Forms;

namespace MapApp.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            // InitializeComponent();
        }

        private void login_OnClicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Home());
            var tt = "bienvenue dans notre application ";
            CrossTextToSpeech.Current.Speak(tt);
        }
        private async void Login_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainCsPage());
        }
    }
}
