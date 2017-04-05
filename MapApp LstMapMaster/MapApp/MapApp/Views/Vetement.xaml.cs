using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using MapApp.Data;
using Xamarin.Forms;

namespace MapApp.Views
{
    public partial class Vetement : ContentPage
    {
        public Vetement()
        {
            InitializeComponent();
            lstMVA.BindingContext = MVAFactory.BindingWithGrouping();
        }

        private async void OnSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            ListView lv = (ListView)sender;
            var selectedMVA = (MVAFactory.MVA)e.SelectedItem;
            bool isOk = await DisplayAlert(selectedMVA.Title, selectedMVA.Prix, " Detail", "Up");

            if (isOk)
            {
                await Navigation.PushAsync(new ChemisFemme1(selectedMVA));
                //Navigation.PushModalAsync(new ChemisFemme1(selectedMVA));
            }


            lv.SelectedItem = null;
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            MVAFactory.RefreshCount++;
            lstMVA.BindingContext = MVAFactory.BindingWithGrouping();
            lstMVA.IsRefreshing = false;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length > 3)
            {
                lstMVA.BindingContext = MVAFactory.BindingWithGrouping(e.NewTextValue);
            }
            else if (string.IsNullOrEmpty(e.NewTextValue))
            {
                lstMVA.BindingContext = MVAFactory.BindingWithGrouping();
            }
        }

        private void OnMenuItemClicked(object sender, EventArgs e)
        {
            DisplayAlert("Detail", "Are you interested in seeing the details", "Ok", "Up");
        }
    }
}
