using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.TextToSpeech;
using Xamarin.Forms;
using XamarinForms.Models;
using XamarinForms.ViewModels;

namespace MapApp.Views
{
    public partial class Page1 : MasterDetailPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void List_OnClicked(object sender, EventArgs e)
        {
            Detail = new Vetement();
            IsPresented = false;
            var t0 = "voici nos  produits qui est consultés récemment";
            CrossTextToSpeech.Current.Speak(t0);
        }

        private async void Maps_OnClicked(object sender, EventArgs e)
        {
            var foursquareViewModel = new FoursquareViewModel();
            await foursquareViewModel.InitDataAsync();


            Detail = new MainPage(foursquareViewModel);
            IsPresented = false;
        }

        private void Menu_OnTapped(object sender, EventArgs e)
        {
            Detail = new Home();
            IsPresented = false;
            var t1 = "bienvennue dans notre application  my clothers développé par ghénimi yosra";
            CrossTextToSpeech.Current.Speak(t1);
        }

        private void Login_OnTapped(object sender, EventArgs e)
        {
            Detail = new LoginFacebook();
            IsPresented = false;
            var t2 = "vous pouvez connecter avec facebook , google gmail ou-bien twitter";
            CrossTextToSpeech.Current.Speak(t2);

        }

        private void Vendre_OnTapped(object sender, EventArgs e)
        {
            Detail = new Vendre();
            IsPresented = false;
            var t3 = "vous pouvez Vendre ton Vêtements";
            CrossTextToSpeech.Current.Speak(t3);

        }
    }
}
