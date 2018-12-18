using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TMDBConnect.Services;
using TMDBConnect.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TMDBConnect
{
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        public static string APIKey = "46d9a503e62c62f28e94acc84942d41f";
        public static bool UseMockDataStore = true;

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<TMDBDataStore>();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
