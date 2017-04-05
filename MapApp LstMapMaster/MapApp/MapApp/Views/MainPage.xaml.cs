using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.ExternalMaps;
using Plugin.ExternalMaps.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using XamarinForms.ViewModels;

namespace MapApp
{
    public partial class MainPage : ContentPage
    {
        private FoursquareViewModel _foursquareViewModel;

        private Pin selectedPin;
        public MainPage(FoursquareViewModel foursquareViewModel)
        {
            InitializeComponent();
            _foursquareViewModel = foursquareViewModel;

        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            MainMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(36.89, 10.18),
                Distance.FromKilometers(5)));
            var items = _foursquareViewModel.FoursquareVenues.Response.Groups[0].Items;

            foreach (var item in items)
            {
                var pin = new Pin
                {
                    Position = new Position(
                   item.Venue.Location.Lat,
                   item.Venue.Location.Lng),
                    Label = item.Venue.Name,
                    Address = item.Venue.Location.FormattedAddress[0]
                };

                pin.Clicked += Pin_Clicked;
                MainMap.Pins.Add(pin);
            }

        }

        private void Pin_Clicked(object sender, EventArgs eventArgs)
        {
            selectedPin = sender as Pin;

            PlaceStackLayout.BindingContext = _foursquareViewModel.FoursquareVenues.Response
                .Groups[0].Items.First(item => item.Venue.Name == selectedPin?.Label);

            //  DisplayAlert(selectedPin?.Label, selectedPin?.Address, "Ok");

        }

        private void GetDErections_OnClicked(object sender, EventArgs e)
        {
            CrossExternalMaps.Current.NavigateTo(
                selectedPin.Label,
                selectedPin.Position.Latitude,
                selectedPin.Position.Longitude,
                NavigationType.Driving);
        }
    }
}
