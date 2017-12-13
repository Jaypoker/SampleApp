using System;

using Xamarin.Forms;

namespace SampleApp
{
    public class SubPage : ContentPage
    {
        public SubPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

