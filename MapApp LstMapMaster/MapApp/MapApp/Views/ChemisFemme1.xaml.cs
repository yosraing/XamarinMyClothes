using System;
using MapApp.Data;
using Xamarin.Forms;
using XamarinForms.ViewModels;
using Plugin.Messaging;

namespace MapApp.Views
{
    public partial class ChemisFemme1 : ContentPage
    {
        public ChemisFemme1(MVAFactory.MVA selected)
        {
            InitializeComponent();

            lbTitle.Text = selected.Title;
            lbPrix.Text = selected.Prix;
            lbMail.Text = selected.Mail;
            lbphne.Text = selected.Phone;




            // var FI = new Image();
            // Fi.SetBinding(Image.SourceProperty,new Binding("ImageUrl"));
        }




        private async void Map_OnClicked(object sender, EventArgs e)
        {
            var foursquareViewModel = new FoursquareViewModel();
            await foursquareViewModel.InitDataAsync();

            await Navigation.PushAsync(new MainPage(foursquareViewModel));
        }



        private async void Maps_OnClicked(object sender, EventArgs e)
        {
            var foursquareViewModel = new FoursquareViewModel();
            await foursquareViewModel.InitDataAsync();

            await Navigation.PushAsync(new MainPage(foursquareViewModel));
        }

        private void SmS_OnTapped(object sender, EventArgs e)
        {
            var smsMessenger = CrossMessaging.Current.SmsMessenger;
            if (smsMessenger.CanSendSms)
                smsMessenger.SendSms("+27213894839493",
                    "Well hello ther from Xam.Messanger.Plugin");
        }

        private void Phone_OnTapped(object sender, EventArgs e)
        {
            var phoneCallTask = CrossMessaging.Current.PhoneDialer;
            if (phoneCallTask.CanMakePhoneCall)
            {
                phoneCallTask.MakePhoneCall("+21699842736",
                    "Yosra GHNIMI");
            }
        }

        private void Mail_OnTapped(object sender, EventArgs e)
        {
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail("to.plugin@xamarin.com",
                    "xamrin Messaging Plugin",
                    "Well hello there from Xam.Messaging.Plugin");
                var email = new EmailMessageBuilder()
                    .To("to.plugin@xamarin.com")
                    .To("Cc.plugin@xamarin.com")
                    .Bcc(new[]
                    {
                        "bcc1.plugin@xamarin.com",
                        "bcc2.plugin@xamarin.com"
                    })
                    .Subject("Xamarin Messaging Plugin")
                    .Body("Well hello there from Xam.Messaging.Plugin")
                    .Build();
                emailMessenger.SendEmail(email);
            }
        }
    }
}
