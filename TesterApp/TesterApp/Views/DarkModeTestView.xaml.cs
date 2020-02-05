using TesterApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesterApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DarkModeTestView : ContentPage
    {
        public DarkModeTestView()
        {
            InitializeComponent();
            var viewModel = new DarkModeTestViewModel();
            this.BindingContext = viewModel;
        }
    }
}