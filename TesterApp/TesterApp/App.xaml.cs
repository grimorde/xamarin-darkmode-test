using TesterApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TesterApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DarkModeTestView();
        }

        protected override void OnStart()
        {
            base.OnStart();

            base.OnResume();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static string AppTheme
        {
            get; set;
        }
    }
}
