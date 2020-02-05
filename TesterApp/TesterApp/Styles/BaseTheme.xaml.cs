using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesterApp.Styles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseTheme : ResourceDictionary
    {
        public BaseTheme()
        {
            InitializeComponent();
        }
    }
}