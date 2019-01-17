
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
        private readonly object Window;

        public App()
        {
           
            InitializeComponent();

            var mainview = FreshPageModelResolver.ResolvePageModel<MainViewModel>();
            MainPage = new FreshNavigationContainer(mainview);
        }


        protected override void OnStart()
        {
            
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
