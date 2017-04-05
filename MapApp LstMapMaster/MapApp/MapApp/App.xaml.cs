using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookLogin.Views;
using MapApp.Views;
using Xamarin.Forms;
using XamarinForms.ViewModels;
using XamarinForms.Views;

namespace MapApp
{
    public partial class App : Application
    {
        public App()
        {
            //InitializeComponent();

          MainPage = new NavigationPage(new Page1());
        // MainPage = new NavigationPage(new Page1());
        //   MainPage = new NavigationPage(new Vetement());

           // MainPage = new ContentPage
            //{
              //  Content = new ActivityIndicator()
                //{
                  //  IsRunning = true,
                    //IsEnabled = true
                //}

            //};

        }

        protected override async void OnStart()
        {
            // Handle when your app starts
          //  var foursquareViewModel =new FoursquareViewModel();
           //await  foursquareViewModel.InitDataAsync();
           // MainPage = new TabbedPage
           // {
             //   Children =
               // {
                 //   new MainPage(foursquareViewModel),
                   // new FoursquareViewPage(foursquareViewModel)
                //}

           // };
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
