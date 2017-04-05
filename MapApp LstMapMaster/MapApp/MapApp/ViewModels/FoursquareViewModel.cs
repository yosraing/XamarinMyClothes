using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XamarinForms.Models;

namespace XamarinForms.ViewModels
{
    public class FoursquareViewModel : INotifyPropertyChanged
    {

        // use this link to get an api_key : https://foursquare.com/developers/register/
        private const string ClientId = "CSDLTS2HS4TJAGD54TJESHEI2VV3RTHECNHS4NFQCVB2ONIH";
        private const string ClientSecret = "LCU1Z5CRZFCMAKZREWPPHN121JFRXINCCXJOK0RQUGUDWNVF";
        private const string v = "20160611";
        private const string venueId = "40a55d80f964a52020f31ee3";

        // doc : https://developer.foursquare.com/docs/venues/search
        private string apiUrlForVenues = $"https://api.foursquare.com/v2/venues/explore?ll=36.89,10.18&client_id={ClientId}&client_secret={ClientSecret}&v={v}&radius=1000&venuePhotos=1";

        private FoursquareVenues _foursquareVenues;

        public FoursquareVenues FoursquareVenues
        {
            get { return _foursquareVenues; }
            set
            {
                _foursquareVenues = value;
                OnPropertyChanged();
            }
        }

        public FoursquareViewModel()
        {
           // InitDataAsync();
        }

        public async Task InitDataAsync()
        {

            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(apiUrlForVenues);

            FoursquareVenues = JsonConvert.DeserializeObject<FoursquareVenues>(json);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}