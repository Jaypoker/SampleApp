using Xamarin.Forms;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace SampleApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SampleAppPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=29431e93-f3d4-4bc7-80f7-4c755fc11272;" + "uwp={Your UWP App secret here};" +
                            "ios={e6bcd579-e2c8-47bc-82a8-ab8da11dd2d2}",
                   typeof(Analytics), typeof(Crashes));
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
