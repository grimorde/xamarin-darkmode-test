using TesterApp.Styles;
using TesterApp.ViewModels.Base;
using Xamarin.Forms;

namespace TesterApp.ViewModels
{
    public class DarkModeTestViewModel : ExtendedBindableObject
    {
        private bool _darkMode;

        public DarkModeTestViewModel()
        {
            string test = "I am here";
            SelectedTheme = "light";
        }

        public bool DarkMode
        {
            get => _darkMode;
            set
            {
                _darkMode = value;
                SetStyle();
                RaisePropertyChanged(() => DarkMode);
            }
        }

        public string SelectedTheme { get; set; }

        private void SetStyle()
        {
            if (DarkMode)
            {
                Application.Current.Resources = new DarkTheme();
                SelectedTheme = "dark";
            }
            else
            {
                Application.Current.Resources = new LightTheme();
                SelectedTheme = "light";
            }
            App.AppTheme = SelectedTheme.ToLower();
        }
    }
}