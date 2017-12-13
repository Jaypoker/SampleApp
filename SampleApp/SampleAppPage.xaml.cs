using System;
using Xamarin.Forms;

namespace SampleApp
{
    public partial class SampleAppPage : ContentPage
    {
        public SampleAppPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {

            var ans = await DisplayAlert("Confirmation", "Would you like to view Page 2","Ok","Cancel");

            if(ans.Equals(true))
            {
                await Navigation.PushAsync(new Page2());
            }

        }
    }
}
