
using Dobble.ViewModels;
using FreshMvvm;
using System;
using Windows.UI.ViewManagement;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Dobble
{
  
    public partial class App : Application
    {
        public int aantal = 0;
        public App()
        {
           
            InitializeComponent();

            var mainview = FreshPageModelResolver.ResolvePageModel<MainViewModel>();
            MainPage = new FreshNavigationContainer(mainview);
        }


        protected override void OnStart()
        {
            if (Device.RuntimePlatform == Device.UWP)
            {
                // ApplicationView.PreferredLaunchViewSize = new Size { Height = 550, Width = 360 };
                //ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
                //ApplicationView.PreferredLaunchViewSize
                // Handle when your app starts
                //   ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(1200, 800));
                //   ApplicationView.PreferredLaunchViewSize = new Size(400, 600); ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            }
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
